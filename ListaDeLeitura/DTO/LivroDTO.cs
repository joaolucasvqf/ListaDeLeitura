using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTO
{
    public partial class LivroDTO
    {
        public string Kind { get; set; }
        public string Id { get; set; }
        public string Etag { get; set; }
        public Uri SelfLink { get; set; }
        public VolumeInfo VolumeInfo { get; set; }
        public SaleInfo SaleInfo { get; set; }
        public AccessInfo AccessInfo { get; set; }
        public SearchInfo SearchInfo { get; set; }
    }
    public partial class AccessInfo
    {
        public string Country { get; set; }
        public string Viewability { get; set; }
        public bool Embeddable { get; set; }
        public bool PublicDomain { get; set; }
        public string TextToSpeechPermission { get; set; }
        public Epub Epub { get; set; }
        public Epub Pdf { get; set; }
        public Uri WebReaderLink { get; set; }
        public string AccessViewStatus { get; set; }
        public bool QuoteSharingAllowed { get; set; }
    }
    public partial class Epub
    {
        public bool IsAvailable { get; set; }
        public Uri AcsTokenLink { get; set; }
    }
    public partial class SaleInfo
    {
        public string Country { get; set; }
        public string Saleability { get; set; }
        public bool IsEbook { get; set; }
        public SaleInfoListPrice ListPrice { get; set; }
        public SaleInfoListPrice RetailPrice { get; set; }
        public Uri BuyLink { get; set; }
        public Offer[] Offers { get; set; }
    }
    public partial class SaleInfoListPrice
    {
        public double Amount { get; set; }
        public string CurrencyCode { get; set; }
    }
    public partial class Offer
    {
        public long FinskyOfferType { get; set; }
        public OfferListPrice ListPrice { get; set; }
        public OfferListPrice RetailPrice { get; set; }
        public bool Giftable { get; set; }
    }
    public partial class OfferListPrice
    {
        public long AmountInMicros { get; set; }
        public string CurrencyCode { get; set; }
    }
    public partial class SearchInfo
    {
        public string TextSnippet { get; set; }
    }
    public partial class VolumeInfo
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        public IndustryIdentifier[] IndustryIdentifiers { get; set; }
        public ReadingModes ReadingModes { get; set; }
        public long PageCount { get; set; }
        public string PrintType { get; set; }
        public string[] Categories { get; set; }
        public string MaturityRating { get; set; }
        public bool AllowAnonLogging { get; set; }
        public string ContentVersion { get; set; }
        public PanelizationSummary PanelizationSummary { get; set; }

        public ImageLinks ImageLinks { get; set; }
        public string Language { get; set; }
        public Uri PreviewLink { get; set; }
        public Uri InfoLink { get; set; }
        public Uri CanonicalVolumeLink { get; set; }
    }
    public partial class ImageLinks
    {
        public Uri SmallThumbnail { get; set; }
        public Uri Thumbnail { get; set; }
    }
    public partial class IndustryIdentifier
    {
        public string Type { get; set; }
        public string Identifier { get; set; }
    }
    public partial class PanelizationSummary
    {
        public bool ContainsEpubBubbles { get; set; }
        public bool ContainsImageBubbles { get; set; }
    }
    public partial class ReadingModes
    {
        public bool Text { get; set; }
        public bool Image { get; set; }
    }
}
