﻿using System;
using System.Collections.Generic;

namespace Overt.Core.Grpc.H2
{
    /// <summary>
    /// 重点服务发现接口
    /// </summary>
    public interface IEndpointDiscovery
    {
        /// <summary>
        /// 服务名称
        /// </summary>
        string ServiceName { get; set; }

        /// <summary>
        /// http / https
        /// </summary>
        string Scheme { get; set; }

        /// <summary>
        /// 监听变动的方法
        /// </summary>
        Action Watched { get; set; }

        /// <summary>
        /// 获取服务可连接终结点
        /// </summary>
        /// <returns></returns>
        List<(string serviceId, string target)> FindServiceEndpoints(bool filterBlack = true);
    }
}
