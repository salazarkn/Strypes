﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Strypes.Web.MongoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/Strypes.Services")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _id {
            get {
                return this._idField;
            }
            set {
                if ((object.ReferenceEquals(this._idField, value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Strypes.Services")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryIdField, value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _id {
            get {
                return this._idField;
            }
            set {
                if ((object.ReferenceEquals(this._idField, value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MongoService.IMongoService")]
    public interface IMongoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/GetCategories", ReplyAction="http://tempuri.org/IMongoService/GetCategoriesResponse")]
        System.Collections.Generic.List<Strypes.Web.MongoService.Category> GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/GetProducts", ReplyAction="http://tempuri.org/IMongoService/GetProductsResponse")]
        System.Collections.Generic.List<Strypes.Web.MongoService.Product> GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/GetProductsBy", ReplyAction="http://tempuri.org/IMongoService/GetProductsByResponse")]
        System.Collections.Generic.List<Strypes.Web.MongoService.Product> GetProductsBy(string searchField, string searchString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/InsertCategory", ReplyAction="http://tempuri.org/IMongoService/InsertCategoryResponse")]
        string InsertCategory(Strypes.Web.MongoService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/DeleteCategory", ReplyAction="http://tempuri.org/IMongoService/DeleteCategoryResponse")]
        void DeleteCategory(string categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/UpdateCategory", ReplyAction="http://tempuri.org/IMongoService/UpdateCategoryResponse")]
        void UpdateCategory(Strypes.Web.MongoService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/GetProductsByCategory", ReplyAction="http://tempuri.org/IMongoService/GetProductsByCategoryResponse")]
        System.Collections.Generic.List<Strypes.Web.MongoService.Product> GetProductsByCategory(string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/InsertProduct", ReplyAction="http://tempuri.org/IMongoService/InsertProductResponse")]
        string InsertProduct(Strypes.Web.MongoService.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/DeleteProduct", ReplyAction="http://tempuri.org/IMongoService/DeleteProductResponse")]
        void DeleteProduct(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMongoService/UpdateProduct", ReplyAction="http://tempuri.org/IMongoService/UpdateProductResponse")]
        void UpdateProduct(Strypes.Web.MongoService.Product product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMongoServiceChannel : Strypes.Web.MongoService.IMongoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MongoServiceClient : System.ServiceModel.ClientBase<Strypes.Web.MongoService.IMongoService>, Strypes.Web.MongoService.IMongoService {
        
        public MongoServiceClient() {
        }
        
        public MongoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MongoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MongoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MongoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Strypes.Web.MongoService.Category> GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public System.Collections.Generic.List<Strypes.Web.MongoService.Product> GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Collections.Generic.List<Strypes.Web.MongoService.Product> GetProductsBy(string searchField, string searchString) {
            return base.Channel.GetProductsBy(searchField, searchString);
        }
        
        public string InsertCategory(Strypes.Web.MongoService.Category category) {
            return base.Channel.InsertCategory(category);
        }
        
        public void DeleteCategory(string categoryId) {
            base.Channel.DeleteCategory(categoryId);
        }
        
        public void UpdateCategory(Strypes.Web.MongoService.Category category) {
            base.Channel.UpdateCategory(category);
        }
        
        public System.Collections.Generic.List<Strypes.Web.MongoService.Product> GetProductsByCategory(string category) {
            return base.Channel.GetProductsByCategory(category);
        }
        
        public string InsertProduct(Strypes.Web.MongoService.Product product) {
            return base.Channel.InsertProduct(product);
        }
        
        public void DeleteProduct(string productId) {
            base.Channel.DeleteProduct(productId);
        }
        
        public void UpdateProduct(Strypes.Web.MongoService.Product product) {
            base.Channel.UpdateProduct(product);
        }
    }
}
