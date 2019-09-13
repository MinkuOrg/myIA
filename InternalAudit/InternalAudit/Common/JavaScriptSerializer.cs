using System;

namespace InternalAudit.Common
{
    internal class JavaScriptSerializer
    {
        public JavaScriptSerializer()
        {
        }

        internal object Serialize(object value)
        {
            throw new NotImplementedException();
        }

        internal T Deserialize<T>(string slug) where T : class
        {
            throw new NotImplementedException();
        }
    }
}