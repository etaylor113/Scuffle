using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class EventModel
    {
        public class SearchParams
        {
            public string topic { get; set; }
            public string state { get; set; }
        } 

        public  class EventSearchRootObjectModel
        {
            public List<SearchParams> searchParams { get; set; }
        }


        public class Topic
        {
            public object topicId { get; set; }
            public string topicName { get; set; }
            public string topicTaxonomy { get; set; }
        }

        public class AssetTopic
        {
            public object sequence { get; set; }
            public Topic topic { get; set; }
        }

        public class Channel
        {
            public string channelDsc { get; set; }
            public string channelName { get; set; }
            public object channelId { get; set; }
        }

        public class AssetChannel
        {
            public object sequence { get; set; }
            public Channel channel { get; set; }
        }

        public class AssetLegacyData
        {
            public string maxTeamNb { get; set; }
            public string assetTypeId { get; set; }
            public string costAmt { get; set; }
            public string typeName { get; set; }
            public string uploadSearchUrlAdr { get; set; }
            public string avgUserRatingTxt { get; set; }
            public string trackbackUrl { get; set; }
            public string seoUrl { get; set; }
            public string eventCategories { get; set; }
            public string estParticipantNb { get; set; }
            public string participationCriteriaTxt { get; set; }
            public string priceExtensionTxt { get; set; }
            public object isSearchable { get; set; }
            public object onlineMembership { get; set; }
            public string minGuaranteedGameNb { get; set; }
            public string searchWeight { get; set; }
            public string userCommentTxt { get; set; }
            public string substitutionUrl { get; set; }
            public object onlineDonation { get; set; }
            public string genderRequirementTxt { get; set; }
            public string createdDate { get; set; }
            public string onlineMembershipCostAmt { get; set; }
            public string authorName { get; set; }
            public object onlineRegistration { get; set; }
            public string modifiedDate { get; set; }
            public string multipleStartDate { get; set; }
        }

        public class ComponentInUrlAdr
        {
        }

        public class ActivenetTopGraphic
        {
        }

        public class Market
        {
            public string marketName { get; set; }
            public object marketId { get; set; }
        }

        public class Attribute
        {
            public object tagId { get; set; }
            public string attributeValue { get; set; }
            public string attributeType { get; set; }
        }

        public class AssetAttribute
        {
            public Attribute attribute { get; set; }
        }

        public class MediaType
        {
            public string mediaTypeName { get; set; }
            public string mediaTypeDsc { get; set; }
            public object mediaTypeId { get; set; }
        }

        public class AssetMediaType
        {
            public object sequence { get; set; }
            public MediaType mediaType { get; set; }
        }

        public class AssetParentAsset
        {
            public string assetGuid { get; set; }
        }

        public class AssetStatus
        {
            public string assetStatusId { get; set; }
            public string assetStatusName { get; set; }
        }

        public class SourceSystem
        {
            public string sourceSystemName { get; set; }
            public string legacyGuid { get; set; }
            public object affiliate { get; set; }
        }

        public class EvergreenParentAsset
        {
        }

        public class Tag
        {
            public object tagId { get; set; }
            public string tagName { get; set; }
            public string tagDescription { get; set; }
        }

        public class AssetTag
        {
            public Tag tag { get; set; }
        }

        public class AssetRootAsset
        {
            public string assetGuid { get; set; }
        }

        public class GeoPoint
        {
            public string lon { get; set; }
            public string lat { get; set; }
        }

        public class Dma
        {
            public object dmaId { get; set; }
            public string dmaName { get; set; }
        }

        public class Place
        {
            public string placeDsc { get; set; }
            public string placeUrlAdr { get; set; }
            public string timezone { get; set; }
            public string postalCode { get; set; }
            public string latitude { get; set; }
            public string directionsTxt { get; set; }
            public string addressLine2Txt { get; set; }
            public GeoPoint geoPoint { get; set; }
            public string addressLine1Txt { get; set; }
            public string stateProvinceCode { get; set; }
            public string localityName { get; set; }
            public string cityName { get; set; }
            public int? timezoneOffset { get; set; }
            public int? timezoneDST { get; set; }
            public string countryCode { get; set; }
            public Dma dma { get; set; }
            public string countryName { get; set; }
            public string placeGuid { get; set; }
            public string placeName { get; set; }
            public string longitude { get; set; }
        }

        public class Category
        {
            public string categoryName { get; set; }
            public object categoryId { get; set; }
            public string categoryTaxonomy { get; set; }
        }

        public class AssetCategory
        {
            public object sequence { get; set; }
            public Category category { get; set; }
        }

        public class AssetQuantity
        {
            public string waitlistCnt { get; set; }
            public string soldCnt { get; set; }
            public string createdDate { get; set; }
            public string availableCnt { get; set; }
            public string modifiedDate { get; set; }
            public string capacityNb { get; set; }
            public string waitlistCapacityNb { get; set; }
        }

        public class Organization
        {
            public string primaryContactName { get; set; }
            public string organizationName { get; set; }
            public string addressPostalCd { get; set; }
            public object sourceSystemId { get; set; }
            public string imageUrlAdr { get; set; }
            public string addressCityName { get; set; }
            public string organizationGuid { get; set; }
            public string primaryContactPhone { get; set; }
            public string addressLine2Txt { get; set; }
            public string shortDsc { get; set; }
            public string addressLine1Txt { get; set; }
            public string addressLocalityName { get; set; }
            public string organizationDsc { get; set; }
            public string organizationUrlAdr { get; set; }
            public object hideOrganizationContact { get; set; }
            public object isDeleted { get; set; }
            public string addressStateProvinceCode { get; set; }
            public string sourceSystemGuid { get; set; }
            public string addressCountryCd { get; set; }
            public object showOrganizationName { get; set; }
            public string fax { get; set; }
        }

        public class ClickTypes
        {
            public int otherActive { get; set; }
            public int registration { get; set; }
            public int nonActive { get; set; }
        }

        public class AssetPopularity
        {
            public int searches { get; set; }
            public int createdAt { get; set; }
            public ClickTypes clickTypes { get; set; }
            public int clicks { get; set; }
            public int rank { get; set; }
            public int results { get; set; }
            public int views { get; set; }
            public int A3Rank { get; set; }
        }

        public class SponsoredContent
        {
        }

        public class Result
        {
            public List<AssetTopic> assetTopics { get; set; }
            public string salesEndDate { get; set; }
            public string regReqGenderCd { get; set; }
            public string registrationUrlAdr { get; set; }
            public string retryDate { get; set; }
            public List<object> evergreenAssets { get; set; }
            public List<object> assetSeoUrls { get; set; }
            public object publishDate { get; set; }
            public List<AssetChannel> assetChannels { get; set; }
            public object sorCreateDtm { get; set; }
            public object dynamicPriceIncluded { get; set; }
            public string localeCd { get; set; }
            public List<object> activityRecurrences { get; set; }
            public AssetLegacyData assetLegacyData { get; set; }
            public string activityEndDate { get; set; }
            public List<object> assetDeals { get; set; }
            public string assetServiceHostName { get; set; }
            public object childIndex { get; set; }
            public List<object> assetDescriptions { get; set; }
            public ComponentInUrlAdr componentInUrlAdr { get; set; }
            public string activityStartDate { get; set; }
            public object volumePriceIncluded { get; set; }
            public string contactName { get; set; }
            public string sorCreateUserId { get; set; }
            public string localTimeZoneId { get; set; }
            public List<object> socialMedia { get; set; }
            public string donationUrlAdr { get; set; }
            public ActivenetTopGraphic activenetTopGraphic { get; set; }
            public List<object> assetReferences { get; set; }
            public Market market { get; set; }
            public List<AssetAttribute> assetAttributes { get; set; }
            public string timezoneAbb { get; set; }
            public List<AssetMediaType> assetMediaTypes { get; set; }
            public string evergreenAssetFlag { get; set; }
            public string authorName { get; set; }
            public string registrantSearchUrlAdr { get; set; }
            public string modifiedDate { get; set; }
            public string timezoneName { get; set; }
            public string showContact { get; set; }
            public AssetParentAsset assetParentAsset { get; set; }
            public AssetStatus assetStatus { get; set; }
            public object regReqMaxAge { get; set; }
            public string currencyCd { get; set; }
            public string resultsUrlAdr { get; set; }
            public List<object> assetImages { get; set; }
            public SourceSystem sourceSystem { get; set; }
            public string assetGuid { get; set; }
            public string timezone { get; set; }
            public EvergreenParentAsset evergreenParentAsset { get; set; }
            public List<AssetTag> assetTags { get; set; }
            public AssetRootAsset assetRootAsset { get; set; }
            public string preferredUrlAdr { get; set; }
            public string logoUrlAdr { get; set; }
            public List<object> assetPrices { get; set; }
            public string detailPageTemplateId { get; set; }
            public List<object> assetComponents { get; set; }
            public string teamUrlAdr { get; set; }
            public string sorId { get; set; }
            public Place place { get; set; }
            public object overrideSeourlFlag { get; set; }
            public List<AssetCategory> assetCategories { get; set; }
            public string urlAdr { get; set; }
            public object retryCounter { get; set; }
            public List<object> assetInterests { get; set; }
            public string assetDsc { get; set; }
            public string contactTxt { get; set; }
            public string alternateName { get; set; }
            public object regReqMinAge { get; set; }
            public string createdDate { get; set; }
            public List<object> assetMetaInterests { get; set; }
            public string salesStartDate { get; set; }
            public string homePageUrlAdr { get; set; }
            public AssetQuantity assetQuantity { get; set; }
            public Organization organization { get; set; }
            public string assetName { get; set; }
            public string contactPhone { get; set; }
            public double searchScore { get; set; }
            public int assetVersion { get; set; }
            public string salesStatus { get; set; }
            public string assetRegistrableStatus { get; set; }
            public AssetPopularity assetPopularity { get; set; }
            public SponsoredContent sponsoredContent { get; set; }
        }

        public class RootObject
        {
            public int retries { get; set; }
            public int total_results { get; set; }
            public int items_per_page { get; set; }
            public int start_index { get; set; }
            public List<object> facets { get; set; }
            public List<object> facet_values { get; set; }
            public List<object> suggestions { get; set; }
            public List<Result> results { get; set; }
            public int radius { get; set; }
            public string start_date { get; set; }
            public object sort { get; set; }
        }



    }
}