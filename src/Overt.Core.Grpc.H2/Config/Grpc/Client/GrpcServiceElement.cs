﻿namespace Overt.Core.Grpc.H2
{
    public class GrpcServiceElement
    {
        /// <summary>
        /// 服务名称
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        public int MaxRetry
        {
            get; set;
        }

        /// <summary>
        /// 服务发现
        /// </summary>
        public GrpcDiscoveryElement Discovery
        {
            get; set;
        }
    }
}
