/*
 *所有关于Cards类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*CardsService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/

using System;
using System.Collections.Generic;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.Core.ManageUser;
using VOL.Manager.IRepositories;
using VOL.Manager.Repositories;

namespace VOL.Manager.Services
{
    public partial class CardsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICardsRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public CardsService(
            ICardsRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        public async Task<WebResponseContent> CardsGenerate(CardsSet cardsSet)
        {
            WebResponseContent responseContent=new WebResponseContent();
            var shop = ShopsRepository.Instance.FindFirst(x => x.User_Id == UserContext.Current.UserId);
            if (shop.IsNullOrEmpty())
            {
                return responseContent.Error("商家信息未设定");
            }
            var startnumber= (shop.Prefix.ToLong() * 10000 + shop.Middle.ToLong()) * 10000;
            
            var cardslist=new List<Cards>();
            for (int i = 0; i < cardsSet.Qty; i++)
            {
                var cardno = startnumber + i;
                Cards card=new Cards();
                card.Card_Name = cardsSet.Card_Name;
                card.Card_No = cardno.ToString();
                Random ran = new Random();
                card.Card_Pwd = ran.Next(100000, 999999).ToString();
                card.Card_Status = 0;
                card.Card_Ship_Status = 0;
                card.CateGory_Id = cardsSet.CateGory_Id;
                card.CreateDate = DateTime.Now;
                card.Customer_Id = cardsSet.Customer_Id;
                card.Expiry_Time = cardsSet.Expiry_Time;
                card.Price = cardsSet.Price;
                card.Strategy_Id = cardsSet.Strategy_Id;
                card.Remark = cardsSet.Remark;
                card.Sku_Id = cardsSet.Sku_Id;
                card.CreateDate=DateTime.Now;
                card.CreateID = UserContext.Current.UserId;
                card.Creator = UserContext.Current.UserName;
                cardslist.Add(card);
            }
            _repository.AddRange(cardslist,true);
            shop.Middle += 1;
            ShopsRepository.Instance.Update(shop);
            return  responseContent.OK("生成成功");
        }
  }
}
