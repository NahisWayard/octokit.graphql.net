namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of AcceptTopicSuggestion
    /// </summary>
    public class AcceptTopicSuggestionPayload : QueryableValue<AcceptTopicSuggestionPayload>
    {
        public AcceptTopicSuggestionPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The accepted topic.
        /// </summary>
        public Topic Topic => this.CreateProperty(x => x.Topic, Octokit.GraphQL.Model.Topic.Create);

        internal static AcceptTopicSuggestionPayload Create(Expression expression)
        {
            return new AcceptTopicSuggestionPayload(expression);
        }
    }
}