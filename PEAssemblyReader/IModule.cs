﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IModule.cs" company="">
//   
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PEAssemblyReader
{
    /// <summary>
    /// </summary>
    public interface IModule
    {
        /// <summary>
        /// </summary>
        /// <param name="token">
        /// </param>
        /// <param name="typeGenerics">
        /// </param>
        /// <param name="methodGenerics">
        /// </param>
        /// <returns>
        /// </returns>
        IField ResolveField(int token, IGenericContext genericContext);

        /// <summary>
        /// </summary>
        /// <param name="token">
        /// </param>
        /// <param name="typeGenerics">
        /// </param>
        /// <param name="methodGenerics">
        /// </param>
        /// <returns>
        /// </returns>
        IMember ResolveMember(int token, IGenericContext genericContext);

        /// <summary>
        /// </summary>
        /// <param name="token">
        /// </param>
        /// <param name="typeGenerics">
        /// </param>
        /// <param name="methodGenerics">
        /// </param>
        /// <returns>
        /// </returns>
        IMethod ResolveMethod(int token, IGenericContext genericContext);

        /// <summary>
        /// </summary>
        /// <param name="token">
        /// </param>
        /// <returns>
        /// </returns>
        string ResolveString(int token);

        /// <summary>
        /// </summary>
        /// <param name="token">
        /// </param>
        /// <param name="typeGenerics">
        /// </param>
        /// <param name="methodGenerics">
        /// </param>
        /// <returns>
        /// </returns>
        IType ResolveType(int token, IGenericContext genericContext);

        /// <summary>
        /// </summary>
        /// <param name="s">
        /// </param>
        /// <param name="typeGenerics">
        /// </param>
        /// <param name="methodGenerics">
        /// </param>
        /// <returns>
        /// </returns>
        IType ResolveType(string s, IGenericContext genericContext);
    }
}