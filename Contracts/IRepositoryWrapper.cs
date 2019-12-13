using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IPersonRepository Person { get; }
        IMarriageRepository Marriage { get; }
        void Save();
    }
}