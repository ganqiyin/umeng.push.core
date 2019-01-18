﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Umeng.Push.Core.Notification.IOS
{
    public class IOSCustomizedcast : IOSNotification
    {
        public IOSCustomizedcast(String appkey, String appMasterSecret)
        {
            SetPredefinedKeyValue("type", "customizedcast");
        }

        /// <summary>
        /// 设置别名
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="aliasType"></param>
        public void SetAlias(string alias, string aliasType= "alias_type")
        {
            SetPredefinedKeyValue("alias", alias);
            SetPredefinedKeyValue("alias_type", aliasType);
        }

        /// <summary>
        /// 将alias存放到文件后，根据file_id来推送
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="aliasType"></param>
        public void SetFileId(string fileId, string aliasType = "alias_type")
        {
            SetPredefinedKeyValue("file_id", fileId);
            SetPredefinedKeyValue("alias_type", aliasType);
        }
    }
}
