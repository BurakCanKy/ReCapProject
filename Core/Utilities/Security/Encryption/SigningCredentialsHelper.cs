namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        // WebAPI'nin doğrulaması için oluşturduk.
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
