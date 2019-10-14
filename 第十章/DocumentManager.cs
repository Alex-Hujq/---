using System;
using System.Collections.Generic;
using System.Text;

namespace 第十章
{
    public class DocumentManager
    {
        private readonly Queue<Document1> documentQueue = new Queue<Document1>();

        public void AddDocument(Document1 doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public Document1 GetDocument()
        {
            Document1 doc = null;
            lock (this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }

        public bool IsDocumentAvailable
        {
            get
            {
                return documentQueue.Count > 0;
            }
        }
    }
}
