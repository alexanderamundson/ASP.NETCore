public class ClaimsPrincipalFactory : UserClaimsPrincipalFactory<User>
{
    private readonly IApiClient _apiClient;

    public ClaimsPrincipalFactory(IApiClient apiClient, UserManager<User> userManager, IOptions<IdentityOptions> optionsAccessor)
        : base(userManager, optionsAccessor)
    {
        _apiClient = apiClient;
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
    {
        var identity = await base.GenerateClaimsAsync(user);

        if (user.IsAdmin)
        {
            identity.MakeAdmin();
        }

        return identity;
    }
}