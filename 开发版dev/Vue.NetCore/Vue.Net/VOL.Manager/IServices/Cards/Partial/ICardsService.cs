/*
*所有关于Cards类的业务代码接口应在此处编写
*/
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VOL.Manager.IServices
{
    public partial interface ICardsService
    {
        public Task<WebResponseContent> CardsGenerate(CardsSet cardsSet);
    }
 }
