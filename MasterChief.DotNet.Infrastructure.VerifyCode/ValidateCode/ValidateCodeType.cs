﻿namespace MasterChief.DotNet.Infrastructure.VerifyCode.ValidateCode
{
    /// <summary>
    ///     图片验证码抽象类
    /// </summary>
    public abstract class ValidateCodeType
    {
        #region Methods

        /// <summary>
        ///     创建验证码抽象方法
        /// </summary>
        /// <param name="validataCode">验证code</param>
        /// <returns>Byte数组</returns>
        public abstract byte[] CreateImage(out string validataCode);

        #endregion Methods

        #region Constructors

        #endregion Constructors

        #region Properties

        /// <summary>
        ///     验证码类型名称
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        ///     验证码Tooltip
        /// </summary>
        public virtual string Tip => "请输入图片中的字符";

        /// <summary>
        ///     类型名称
        /// </summary>
        public string Type => GetType().Name;

        #endregion Properties
    }
}