using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Linq;
using PegasusDataStore.Documents;
using Microsoft.Azure.Documents;

namespace PegasusDataStore
{
    public static class DocumentExtensions
    {
        public static async Task<List<T>> ExecuteToListAsync<T>(this IDocumentQuery<T> documentQuery) where T : DocumentBase
        {
            var documentList = new List<T>();
            while (documentQuery.HasMoreResults)
            {
                var documentResult = await documentQuery.ExecuteNextAsync();
                foreach (var document in documentResult)
                {
                    var readDocument = (T)document;
                    readDocument.ETag = ((Document)document).ETag;
                    documentList.Add(readDocument);
                }
            }

            return documentList;
        }

        public static async Task<T> ExecuteFirstOrDefaultAsync<T>(this IDocumentQuery<T> documentQuery) where T : DocumentBase
        {
            var documentList = await documentQuery.ExecuteToListAsync();
            return documentList.FirstOrDefault();
        }

        public static int ToEpoch(this DateTime date)
        {
            if (date == null)
            {
                return int.MinValue;
            }

            var epoch = new DateTime(1970, 1, 1);
            var epochTimeSpan = date - epoch;
            return (int)epochTimeSpan.TotalSeconds;
        }
    }
}
