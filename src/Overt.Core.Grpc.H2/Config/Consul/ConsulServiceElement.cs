﻿#if !ASP_NET_CORE
using System.Configuration;
#endif

namespace Overt.Core.Grpc.H2
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsulServiceElement
#if !ASP_NET_CORE
        : ConfigurationElement
#endif
    {
        /// <summary>
        /// consul地址
        /// </summary>
#if !ASP_NET_CORE
        [ConfigurationProperty("address", IsRequired = true)]
#endif
        public string Address
        {
#if !ASP_NET_CORE
            get { return (string)this["address"]; }
#else
            get;set;
#endif
        }
    }
}
