﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("MyBlogModel2", "FK_BlogPostReply_BlogPost", "Post", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MyBlog.Reporting.Data.Post), "Comment", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MyBlog.Reporting.Data.Comment), true)]
[assembly: EdmRelationshipAttribute("MyBlogModel2", "PostCategoryLinks", "Post", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MyBlog.Reporting.Data.Post), "Category", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MyBlog.Reporting.Data.Category))]

#endregion

namespace MyBlog.Reporting.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MyBlogEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MyBlogEntities object using the connection string found in the 'MyBlogEntities' section of the application configuration file.
        /// </summary>
        public MyBlogEntities() : base("name=MyBlogEntities", "MyBlogEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MyBlogEntities object.
        /// </summary>
        public MyBlogEntities(string connectionString) : base(connectionString, "MyBlogEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MyBlogEntities object.
        /// </summary>
        public MyBlogEntities(EntityConnection connection) : base(connection, "MyBlogEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Category> Categories
        {
            get
            {
                if ((_Categories == null))
                {
                    _Categories = base.CreateObjectSet<Category>("Categories");
                }
                return _Categories;
            }
        }
        private ObjectSet<Category> _Categories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Comment> Comments
        {
            get
            {
                if ((_Comments == null))
                {
                    _Comments = base.CreateObjectSet<Comment>("Comments");
                }
                return _Comments;
            }
        }
        private ObjectSet<Comment> _Comments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Post> Posts
        {
            get
            {
                if ((_Posts == null))
                {
                    _Posts = base.CreateObjectSet<Post>("Posts");
                }
                return _Posts;
            }
        }
        private ObjectSet<Post> _Posts;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Categories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCategories(Category category)
        {
            base.AddObject("Categories", category);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Comments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToComments(Comment comment)
        {
            base.AddObject("Comments", comment);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Posts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPosts(Post post)
        {
            base.AddObject("Posts", post);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MyBlogModel2", Name="Category")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Category : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Category CreateCategory(global::System.Int32 id, global::System.String name)
        {
            Category category = new Category();
            category.Id = id;
            category.Name = name;
            return category;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MyBlogModel2", "PostCategoryLinks", "Post")]
        public EntityCollection<Post> Posts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Post>("MyBlogModel2.PostCategoryLinks", "Post");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Post>("MyBlogModel2.PostCategoryLinks", "Post", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MyBlogModel2", Name="Comment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Comment : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Comment object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="postId">Initial value of the PostId property.</param>
        /// <param name="body">Initial value of the Body property.</param>
        /// <param name="approved">Initial value of the Approved property.</param>
        /// <param name="creationDate">Initial value of the CreationDate property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        public static Comment CreateComment(global::System.Int32 id, global::System.Int32 postId, global::System.String body, global::System.Boolean approved, global::System.DateTime creationDate, global::System.String userName)
        {
            Comment comment = new Comment();
            comment.Id = id;
            comment.PostId = postId;
            comment.Body = body;
            comment.Approved = approved;
            comment.CreationDate = creationDate;
            comment.UserName = userName;
            return comment;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PostId
        {
            get
            {
                return _PostId;
            }
            set
            {
                OnPostIdChanging(value);
                ReportPropertyChanging("PostId");
                _PostId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PostId");
                OnPostIdChanged();
            }
        }
        private global::System.Int32 _PostId;
        partial void OnPostIdChanging(global::System.Int32 value);
        partial void OnPostIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Body
        {
            get
            {
                return _Body;
            }
            set
            {
                OnBodyChanging(value);
                ReportPropertyChanging("Body");
                _Body = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Body");
                OnBodyChanged();
            }
        }
        private global::System.String _Body;
        partial void OnBodyChanging(global::System.String value);
        partial void OnBodyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Approved
        {
            get
            {
                return _Approved;
            }
            set
            {
                OnApprovedChanging(value);
                ReportPropertyChanging("Approved");
                _Approved = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Approved");
                OnApprovedChanged();
            }
        }
        private global::System.Boolean _Approved;
        partial void OnApprovedChanging(global::System.Boolean value);
        partial void OnApprovedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                OnCreationDateChanging(value);
                ReportPropertyChanging("CreationDate");
                _CreationDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreationDate");
                OnCreationDateChanged();
            }
        }
        private global::System.DateTime _CreationDate;
        partial void OnCreationDateChanging(global::System.DateTime value);
        partial void OnCreationDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserEmail
        {
            get
            {
                return _UserEmail;
            }
            set
            {
                OnUserEmailChanging(value);
                ReportPropertyChanging("UserEmail");
                _UserEmail = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UserEmail");
                OnUserEmailChanged();
            }
        }
        private global::System.String _UserEmail;
        partial void OnUserEmailChanging(global::System.String value);
        partial void OnUserEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserWebSite
        {
            get
            {
                return _UserWebSite;
            }
            set
            {
                OnUserWebSiteChanging(value);
                ReportPropertyChanging("UserWebSite");
                _UserWebSite = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UserWebSite");
                OnUserWebSiteChanged();
            }
        }
        private global::System.String _UserWebSite;
        partial void OnUserWebSiteChanging(global::System.String value);
        partial void OnUserWebSiteChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MyBlogModel2", "FK_BlogPostReply_BlogPost", "Post")]
        public Post Post
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Post>("MyBlogModel2.FK_BlogPostReply_BlogPost", "Post").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Post>("MyBlogModel2.FK_BlogPostReply_BlogPost", "Post").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Post> PostReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Post>("MyBlogModel2.FK_BlogPostReply_BlogPost", "Post");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Post>("MyBlogModel2.FK_BlogPostReply_BlogPost", "Post", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MyBlogModel2", Name="Post")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Post : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Post object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="creationDate">Initial value of the CreationDate property.</param>
        /// <param name="lastModifiedDate">Initial value of the LastModifiedDate property.</param>
        /// <param name="subject">Initial value of the Subject property.</param>
        /// <param name="body">Initial value of the Body property.</param>
        /// <param name="commentsEnabled">Initial value of the CommentsEnabled property.</param>
        public static Post CreatePost(global::System.Int32 id, global::System.DateTime creationDate, global::System.DateTime lastModifiedDate, global::System.String subject, global::System.String body, global::System.Boolean commentsEnabled)
        {
            Post post = new Post();
            post.Id = id;
            post.CreationDate = creationDate;
            post.LastModifiedDate = lastModifiedDate;
            post.Subject = subject;
            post.Body = body;
            post.CommentsEnabled = commentsEnabled;
            return post;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                OnCreationDateChanging(value);
                ReportPropertyChanging("CreationDate");
                _CreationDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreationDate");
                OnCreationDateChanged();
            }
        }
        private global::System.DateTime _CreationDate;
        partial void OnCreationDateChanging(global::System.DateTime value);
        partial void OnCreationDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastModifiedDate
        {
            get
            {
                return _LastModifiedDate;
            }
            set
            {
                OnLastModifiedDateChanging(value);
                ReportPropertyChanging("LastModifiedDate");
                _LastModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastModifiedDate");
                OnLastModifiedDateChanged();
            }
        }
        private global::System.DateTime _LastModifiedDate;
        partial void OnLastModifiedDateChanging(global::System.DateTime value);
        partial void OnLastModifiedDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> PublishDate
        {
            get
            {
                return _PublishDate;
            }
            set
            {
                OnPublishDateChanging(value);
                ReportPropertyChanging("PublishDate");
                _PublishDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PublishDate");
                OnPublishDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _PublishDate;
        partial void OnPublishDateChanging(Nullable<global::System.DateTime> value);
        partial void OnPublishDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Subject
        {
            get
            {
                return _Subject;
            }
            set
            {
                OnSubjectChanging(value);
                ReportPropertyChanging("Subject");
                _Subject = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Subject");
                OnSubjectChanged();
            }
        }
        private global::System.String _Subject;
        partial void OnSubjectChanging(global::System.String value);
        partial void OnSubjectChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Body
        {
            get
            {
                return _Body;
            }
            set
            {
                OnBodyChanging(value);
                ReportPropertyChanging("Body");
                _Body = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Body");
                OnBodyChanged();
            }
        }
        private global::System.String _Body;
        partial void OnBodyChanging(global::System.String value);
        partial void OnBodyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean CommentsEnabled
        {
            get
            {
                return _CommentsEnabled;
            }
            set
            {
                OnCommentsEnabledChanging(value);
                ReportPropertyChanging("CommentsEnabled");
                _CommentsEnabled = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CommentsEnabled");
                OnCommentsEnabledChanged();
            }
        }
        private global::System.Boolean _CommentsEnabled;
        partial void OnCommentsEnabledChanging(global::System.Boolean value);
        partial void OnCommentsEnabledChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MyBlogModel2", "FK_BlogPostReply_BlogPost", "Comment")]
        public EntityCollection<Comment> Comments
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Comment>("MyBlogModel2.FK_BlogPostReply_BlogPost", "Comment");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Comment>("MyBlogModel2.FK_BlogPostReply_BlogPost", "Comment", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MyBlogModel2", "PostCategoryLinks", "Category")]
        public EntityCollection<Category> Categories
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Category>("MyBlogModel2.PostCategoryLinks", "Category");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Category>("MyBlogModel2.PostCategoryLinks", "Category", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
