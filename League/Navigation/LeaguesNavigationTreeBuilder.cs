﻿using System.Threading.Tasks;
using cloudscribe.Web.Navigation;
using League.DI;
using Microsoft.Extensions.Localization;

namespace League.Navigation
{
    /// <summary>
    /// Reads the Leagues from configuration and inserts them into the navigation bar.
    /// </summary>
    public class LeaguesNavigationTreeBuilder : INavigationTreeBuilder
    {
        private readonly OrganizationSiteContext _organizationSiteContext;
        private readonly IStringLocalizer<NavigationResource> _localizer;

        public LeaguesNavigationTreeBuilder(OrganizationSiteContext organizationSiteContext, IStringLocalizer<NavigationResource> localizer)
        {
            _organizationSiteContext = organizationSiteContext;
            _localizer = localizer;
        }
        public string Name => string.Join(".", nameof(League), nameof(Navigation), nameof(LeaguesNavigationTreeBuilder));

        public Task<TreeNode<NavigationNode>> BuildTree(NavigationTreeBuilderService service)
        {
            var topNode = new NavigationNode { Text = _localizer["League"], Url = "#"};
            var treeNode = new TreeNode<NavigationNode>(topNode);
            treeNode.AddChild(new NavigationNode { Text = _localizer["Home"], Url = "/welcome", Key = "LeagueWelcome" });
            foreach (var site in _organizationSiteContext.SiteList)
            {
                var siteContext = _organizationSiteContext.Resolve(site.OrganizationKey);
                if (!string.IsNullOrEmpty(siteContext.OrganizationKey) && !siteContext.HideInMenu)
                {
                    treeNode.AddChild(
                        new NavigationNode
                        {
                            Text = siteContext.ShortName,
                            Url = "/" + site.UrlSegmentValue,
                            Key = "UrlSegment_" + site.UrlSegmentValue,
                            PreservedRouteParameters = "organization",
                        });
                }
            }
            treeNode.AddChild(new NavigationNode { Text = _localizer["League Overview"], Url = "/overview", Key = "LeagueOverview" });
            
            // To return a TreeNode, that won't be rendered, use: new TreeNode<NavigationNode>(new NavigationNode());
            return Task.FromResult(treeNode);
        }
    }
}