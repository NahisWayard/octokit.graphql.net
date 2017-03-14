namespace Octoqit
{
    using System.Linq;
    using System.Linq.Expressions;
    using LinqToGraphQL;
    using LinqToGraphQL.Builders;

    /// <summary>
    /// Represents a Milestone object on a given repository.
    /// </summary>
    public class Milestone : QueryEntity
    {
        public Milestone(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the number of issues currently closed in this milestone.
        /// </summary>
        public int ClosedIssueCount { get; }

        /// <summary>
        /// Identifies the creator of the milestone.
        /// </summary>
        public User CreatedBy => this.CreateProperty(x => x.CreatedBy, Octoqit.User.Create);

        /// <summary>
        /// Identifies the description of the milestone.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Identifies the due date of the milestone.
        /// </summary>
        public string DueOn { get; }

        public string Id { get; }

        /// <summary>
        /// Identifies the number of the milestone.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Identifies the number of issues currently open in this milestone.
        /// </summary>
        public int OpenIssueCount { get; }

        /// <summary>
        /// The HTTP path for this milestone
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// The repository associated with this milestone.
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octoqit.Repository.Create);

        /// <summary>
        /// Identifies the state of the milestone.
        /// </summary>
        public MilestoneState State { get; }

        /// <summary>
        /// Identifies the title of the milestone.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// The HTTP url for this milestone
        /// </summary>
        public string Url { get; }

        internal static Milestone Create(IQueryProvider provider, Expression expression)
        {
            return new Milestone(provider, expression);
        }
    }
}