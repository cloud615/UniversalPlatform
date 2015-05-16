using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversalPlatform.RequestAction.Home
{
    public partial class IndexAction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Request["action"];
            string resultJson = string.Empty;
            if (!string.IsNullOrWhiteSpace(action))
            {
                switch (action.ToLower())
                {
                    case "list":
                        resultJson = GetIndexList();
                        break;
                    default:
                        break;
                }
            }
            Response.Write(resultJson);
        }

        private string GetIndexList()
        {
            List<WebSiteModel> list = new List<WebSiteModel>();

            list.Add(new WebSiteModel() { ID = 1, Name = "百度", URL = "http://www.baidu.com" });
            list.Add(new WebSiteModel() { ID = 2, Name = "新浪", URL = "http://www.sina.com" });
            list.Add(new WebSiteModel() { ID = 3, Name = "搜狐", URL = "http://www.sohu.com" });
            list.Add(new WebSiteModel() { ID = 4, Name = "淘宝", URL = "http://www.taobao.com" });
            list.Add(new WebSiteModel() { ID = 5, Name = "天猫", URL = "http://www.tianmao.com" });
            list.Add(new WebSiteModel() { ID = 6, Name = "京东", URL = "http://www.jd.com" });
            list.Add(new WebSiteModel() { ID = 7, Name = "博客园", URL = "http://www.cnblogs.com" });
            list.Add(new WebSiteModel() { ID = 8, Name = "CSDN", URL = "http://www.csdn.com" });
            list.Add(new WebSiteModel() { ID = 9, Name = "天涯", URL = "http://www.tianya.com" });
            list.Add(new WebSiteModel() { ID = 10, Name = "谷歌翻译", URL = "http://translate.google.cn/" });

            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(list);
        }
    }

    public struct WebSiteModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

    }
}