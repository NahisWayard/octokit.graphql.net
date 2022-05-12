namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdatePullRequestBranch
    /// </summary>
    public class UpdatePullRequestBranchPayload : QueryableValue<UpdatePullRequestBranchPayload>
    {
        internal UpdatePullRequestBranchPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The updated pull request.
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.GraphQL.Model.PullRequest.Create);

        internal static UpdatePullRequestBranchPayload Create(Expression expression)
        {
            return new UpdatePullRequestBranchPayload(expression);
        }
    }
}