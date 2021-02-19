using System.Collections.Generic;

namespace Military_Elite.Contracts
{
    interface ILieutenantGeneral : IPrivate
    {
        Dictionary<int, IPrivate> Privates{get;}
    }
}
