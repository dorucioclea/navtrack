using Navtrack.Api.Model.Custom;

namespace Navtrack.Api.Model.Assets
{
    public class AddAssetCommand : BaseCommand<AddAssetRequestModel>
    {
        public int UserId { get; set; }
    }
}