﻿namespace Dreamland.Core.Vision.Match
{
    /// <summary>
    ///     特征点匹配参数
    /// </summary>
    public class FeatureMatchArgument : MatchArgument
    {
        /// <summary>
        ///     比例阈值
        /// <para>该值用于配置匹配点筛选，降低这个比例阈值，匹配点数目会减少，但更加稳定；反之匹配点增加，但错误识别也会增加。</para>
        /// </summary>
        public double Ratio { get; set; } = 0.5;

        /// <summary>
        ///     设置每个特征点查询查找相应的最佳匹配项的个数
        /// <para>值越大，匹配所需时间越长。</para>
        /// </summary>
        public uint MatchPoints { get; set; } = 2;

        /// <summary>
        ///     使用Ransac算法减少噪声
        /// <para>值越小，表示所允许的误差越小。</para>
        /// </summary>
        public uint RansacThreshold { get; set; } = 3;
    }
}
