using System.Security.Claims;

namespace api.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static int GetUserId(this ClaimsPrincipal user)
        {
            var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userIdClaim))
            {
                throw new Exception("User ID claim is missing");
            }

            if (!int.TryParse(userIdClaim, out var userId))
            {
                throw new Exception("User ID claim is not a valid integer");
            }

            return userId;
        }
    }
}
