namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of DisablePullRequestAutoMerge
    /// </summary>
    public class DisablePullRequestAutoMergePayload : QueryableValue<DisablePullRequestAutoMergePayload>
    {
        internal DisablePullRequestAutoMergePayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// Identifies the actor who performed the event.
        /// </summary>
        public IActor Actor => this.CreateProperty(x => x.Actor, Octokit.GraphQL.Model.Internal.StubIActor.Create);

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The pull request auto merge was disabled on.
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.GraphQL.Model.PullRequest.Create);

        internal static DisablePullRequestAutoMergePayload Create(Expression expression)
        {
            return new DisablePullRequestAutoMergePayload(expression);
        }
    }
}