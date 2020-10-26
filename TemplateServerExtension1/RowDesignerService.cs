using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DocsVision.BackOffice.CardLib.CardDefs;
using DocsVision.BackOffice.ObjectModel;
using DocsVision.Platform.WebClient.Helpers;

namespace TemplateServerExtension1
{
    public class RowDesignerServiceController : ApiController
    {

        private readonly IServiceProvider serviceProvider;
        private readonly ServiceHelper serviceHelper;


        public RowDesignerServiceController(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.serviceHelper = new ServiceHelper(serviceProvider);
        }

        [HttpGet]
        public string GetPaymentKindInfo(Guid id)
        {
            var objectContext = this.serviceHelper.CurrentObjectContextProvider.GetOrCreateCurrentSessionContext().ObjectContext;

            try
            {
                BaseUniversalItem card = objectContext.GetObject<BaseUniversalItem>(id);

                return card.Name;
            }
            catch
            {
                return "ses";
            }
        }
    }
}