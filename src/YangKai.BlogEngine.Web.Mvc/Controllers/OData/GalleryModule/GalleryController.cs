﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using AtomLab.Utility;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using YangKai.BlogEngine.Common;
using YangKai.BlogEngine.Domain;
using YangKai.BlogEngine.Service;

namespace YangKai.BlogEngine.Web.Mvc.Controllers.OData
{
    public class GalleryController : EntityController<Gallery>
    {
        [Queryable(AllowedQueryOptions = AllowedQueryOptions.All, PageSize = 1000, MaxExpansionDepth = 5)]
        public override IQueryable<Gallery> Get()
        {
            return Proxy.Repository<Gallery>().GetAll();
        }

        protected override Gallery UpdateEntity(Guid key, Gallery update)
        {
            if (!string.IsNullOrEmpty(update.Cover))
            {
                var filename = update.GalleryId + Path.GetExtension(update.Cover);
                var source = string.Format("{0}/{1}", HttpContext.Current.Server.MapPath("~/upload/temp"),
                    update.Cover);
                var target = string.Format("{0}/{1}", HttpContext.Current.Server.MapPath("~/upload/gallery"),
                    filename);
                if (File.Exists(source))
                {
                    if (File.Exists(target))
                    {
                        File.Delete(target);
                    }
                    File.Move(source, target);
                    ImageProcessing.CutForCustom(target, 300, 300, 100);
                    update.Cover = "/upload/gallery/" + filename;
                }
            }
            return base.UpdateEntity(key, update);
        }

    }
}