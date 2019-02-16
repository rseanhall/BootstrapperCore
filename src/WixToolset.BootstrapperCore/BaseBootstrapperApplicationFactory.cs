// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.BootstrapperCore
{
    public abstract class BaseBootstrapperApplicationFactory : IBootstrapperApplicationFactory
    {
        public IBootstrapperApplication Create(IBootstrapperEngine pEngine, ref Command command)
        {
            var engine = new Engine(pEngine);
            return this.Create(engine, ref command);
        }

        protected abstract IBootstrapperApplication Create(Engine engine, ref Command command);
    }
}
