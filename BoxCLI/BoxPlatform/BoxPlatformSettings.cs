namespace BoxCLI.BoxPlatform
{
    public class BoxPlatformSettings
    {
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string EnterpriseId { get; set; }

        public string JwtPublicKeyId { get; set; }

        public string JwtPrivateKeyFilePath { get; set; }  = "/private_key.pem";

        public string JwtPrivateKeyPassword { get; set; }

    }
}
