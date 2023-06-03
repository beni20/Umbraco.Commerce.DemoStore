//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.0.0-rc2+459d664
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Commerce.DemoStore.Models
{
	// Mixin Content Type with alias "productComp"
	/// <summary>Product</summary>
	public partial interface IProductComp : IPublishedElement
	{
		/// <summary>Price</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Commerce.Cms.Models.PricePropertyValue Price { get; }

		/// <summary>SKU</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Sku { get; }
	}

	/// <summary>Product</summary>
	[PublishedModel("productComp")]
	public partial class ProductComp : PublishedElementModel, IProductComp
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		public new const string ModelTypeAlias = "productComp";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ProductComp, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ProductComp(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Price: Enter a price for this product in each supported currency.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("price")]
		public virtual global::Umbraco.Commerce.Cms.Models.PricePropertyValue Price => GetPrice(this, _publishedValueFallback);

		/// <summary>Static getter for Price</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Commerce.Cms.Models.PricePropertyValue GetPrice(IProductComp that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Commerce.Cms.Models.PricePropertyValue>(publishedValueFallback, "price");

		///<summary>
		/// SKU: The unique SKU of this product.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sku")]
		public virtual string Sku => GetSku(this, _publishedValueFallback);

		/// <summary>Static getter for SKU</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.0-rc2+459d664")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSku(IProductComp that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "sku");
	}
}
