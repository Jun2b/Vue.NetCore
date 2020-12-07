/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下ExpiredsetsService与IExpiredsetsService中编写
 */
using VOL.Manager.IRepositories;
using VOL.Manager.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using VOL.Manager.IRepositories;

namespace VOL.Manager.Services
{
    public partial class ExpiredsetsService : ServiceBase<Expiredsets, IExpiredsetsRepository>
    , IExpiredsetsService, IDependency
    {
    public ExpiredsetsService(IExpiredsetsRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IExpiredsetsService Instance
    {
      get { return AutofacContainerModule.GetService<IExpiredsetsService>(); } }
    }
 }
