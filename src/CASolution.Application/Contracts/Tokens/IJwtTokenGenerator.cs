namespace CASolution.Application.Contracts.Tokens
{
    public interface IJwtTokenGenerator
    {
        public string GenerateToken(TokenGenreateRequest request);
    }
}
