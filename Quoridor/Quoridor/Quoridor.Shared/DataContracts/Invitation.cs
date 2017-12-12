﻿namespace Quoridor.DataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The invitation.
    /// </summary>
    [DataContract]
    public class Invitation
    {
        /// <summary>
        /// Gets or sets the invitation guid string.
        /// </summary>
        [DataMember]
        public string InvitationGuidString { get; set; }

        /// <summary>
        /// Gets or sets the match guid string.
        /// </summary>
        [DataMember]
        public string MatchGuidString { get; set; }

        /// <summary>
        /// Gets or sets the inviting player.
        /// </summary>
        [DataMember]
        public int InvitingPlayerId { get; set; }

        /// <summary>
        /// Gets or sets the invited player.
        /// </summary>
        [DataMember]
        public int InvitedPlayerId { get; set; }
    }
}