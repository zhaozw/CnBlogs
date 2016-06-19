﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//======================================================//
//			作者中文名:	林国杰				            //
//			英文名:		jake				            //
//			创建时间:	6/19/2016 3:02:04 PM			//
//			创建日期:	2016				            //
//======================================================//
namespace CnBlogs.Service
{
    internal class WcfApiUrlConstants
    {
        /// <summary>
        /// 博客园wcf
        /// </summary>
        internal static string CnblogsWcfBaseUrl = "http://wcf.open.CnBlogs.com/";
        #region http://wcf.open.CnBlogs.com/blog/
        internal static string CnblogsWcfBlogUrl = CnblogsWcfBaseUrl + "blog/";
        /// <summary>
        /// itemCount
        /// 48小时阅读排行
        /// </summary>
        internal static string FortyEightHoursTopViewPosts = CnblogsWcfBlogUrl + "48HoursTopViewPosts/{0}";
        /// <summary>
        /// pageIndex,pageSize
        /// 分页获取推荐博客列表
        /// </summary>
        internal static string RecommendedBlogs = CnblogsWcfBlogUrl + "bloggers/recommend/{0}/{1}";
        /// <summary>
        /// 获取推荐博客总数
        /// </summary>
        internal static string RecommendedBlogAmount = CnblogsWcfBlogUrl + "bloggers/recommend/count";
        /// <summary>
        /// 根据作者名搜索博主
        /// </summary>
        internal static string SearchBloggerByAuthorName = CnblogsWcfBlogUrl + "bloggers/search";
        /// <summary>
        /// postId,pageIndex,pageSize
        /// 获取文章评论
        /// </summary>
        internal static string GetComments = CnblogsWcfBlogUrl + "post/{0}/comments/{1}/{2}";
        /// <summary>
        /// postId
        /// 获取文章内容
        /// </summary>
        internal static string GetBody = CnblogsWcfBlogUrl + "post/body/{0}";
        /// <summary>
        /// pageIndex,pageSize 
        /// 分页获取首页文章列表
        /// </summary>
        internal static string SiteHomeArticles = CnblogsWcfBlogUrl + "sitehome/paged/{0}/{1}";
        ///// <summary>
        /////
        ///// itemcount 
        ///// 获取首页文章列表
        ///// </summary>
        //internal static string SiteHomeRecentArticles = CnblogsWcfBlogUrl + "sitehome/paged/{0}";
        /// <summary>
        /// itemcount 
        /// 10天内推荐排行
        /// </summary>
        internal static string TenDaysTopDiggPosts = CnblogsWcfBlogUrl + "TenDaysTopDiggPosts/{0}";
        /// <summary>
        /// blogapp,pageIndex,pageSize 
        /// 分页获取个人博客文章列表
        /// </summary>
        internal static string PersonalBlogs = CnblogsWcfBlogUrl + "u/{blogapp}/posts/{pageIndex}/{pageSize}";
        #endregion
    }
}
