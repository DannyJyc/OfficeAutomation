using System;
using Chloe.Annotations;
namespace OfficeAutomation.Models
{
	/// <summary>
    /// 实体类。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("view_knowledge_type")]
 	//view_knowledge_type
		public partial class view_knowledge_type
	{
		#region 默认值
   	    public view_knowledge_type()
   	    { 	 
			 	         id=0; 			 	 
			 	         addtime= System.DateTime.Now;			 	 
			 	         title= "";			 	 
			 	         content= "";			 	 
			 	         urlstr= "";			 	 
			 	         state= 0;			 	 
			 	         userid=0; 			 	 
			 	         reply=0; 			 	 
			 	         reReply=0; 			 	 
			 	         typeid=0; 			 	 
			 	         name= "";			 
   	    }
   	    #endregion
		
		#region Model
      	/// <summary>
		/// id
		/// </summary>
	    public int id  {get;set;}
		 /// <summary>
		/// 添加时间
		/// </summary>
	    public DateTime? addtime  {get;set;}
		 /// <summary>
		/// 标题
		/// </summary>
	    public string title  {get;set;}
		 /// <summary>
		/// 详情、介绍
		/// </summary>
	    public string content  {get;set;}
		 /// <summary>
		/// 文件路径
		/// </summary>
	    public string urlstr  {get;set;}
		 /// <summary>
		/// 1公开 0私有
		/// </summary>
	    public int state  {get;set;}
		 /// <summary>
		/// 发布id
		/// </summary>
	    public int? userid  {get;set;}
		 /// <summary>
		/// 回复主贴id
		/// </summary>
	    public int? reply  {get;set;}
		 /// <summary>
		/// 引用回复id
		/// </summary>
	    public int? reReply  {get;set;}
		 /// <summary>
		/// 类型id
		/// </summary>
	    public int? typeid  {get;set;}
		 /// <summary>
		/// 类型名称
		/// </summary>
	    public string name  {get;set;}
		  
		  /// <summary>
		 /// 非SQL映射字段 
		 /// </summary>
		 [NotMapped]
   		 public string NotMapped { get; set; }
		 #endregion
	}
}