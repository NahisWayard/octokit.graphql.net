namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of AddProjectNextItem
    /// </summary>
    public class AddProjectNextItemInput
    {
        /// <summary>
        /// The ID of the Project to add the item to.
        /// </summary>
        public ID ProjectId { get; set; }

        /// <summary>
        /// The content id of the item (Issue or PullRequest).
        /// </summary>
        public ID ContentId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}