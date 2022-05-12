namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of EnablePullRequestAutoMerge
    /// </summary>
    public class EnablePullRequestAutoMergePayload : QueryableValue<EnablePullRequestAutoMergePayload>
    {
        internal EnablePullRequestAutoMergePayload(Expression expression) : base(expression)
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
        /// The pull request auto-merge was enabled on.
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.GraphQL.Model.PullRequest.Create);

        internal static EnablePullRequestAutoMergePayload Create(Expression expression)
        {
            return new EnablePullRequestAutoMergePayload(expression);
        }
    }
}