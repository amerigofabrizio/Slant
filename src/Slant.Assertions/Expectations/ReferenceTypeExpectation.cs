﻿using System.Diagnostics;

// ReSharper disable CheckNamespace

namespace Slant.Expectations
{
    /// <summary>
    /// Contains a number of methods to assert that a reference type object is in the expected state.
    /// 
    /// </summary>
    [DebuggerNonUserCode]
    public abstract class ReferenceTypeExpectation<TSubject, TAssertions> where TAssertions : ReferenceTypeExpectation<TSubject, TAssertions>
    {
        /// <summary>
        /// Gets the object which value is being expected.
        /// 
        /// </summary>
        public TSubject Subject { get; protected set; }

        /// <summary>
        /// Returns the type of the subject the assertion applies on.
        /// 
        /// </summary>
        protected abstract string Context { get; }
    }
}