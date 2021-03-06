﻿using System;

namespace Akka.Tools.MatchHandler
{
    public class CompiledMatchHandlerWithArguments
    {
        private readonly Delegate _compiledDelegate;
        private readonly object[] _delegateArguments;

        public CompiledMatchHandlerWithArguments(Delegate compiledDelegate, object[] delegateArguments)
        {
            _compiledDelegate = compiledDelegate;
            _delegateArguments = delegateArguments;
        }

        public Delegate CompiledDelegate { get { return _compiledDelegate; } }

        public object[] DelegateArguments { get { return _delegateArguments; } }
    }
}