﻿namespace Quoridor.DataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The move.
    /// </summary>
    [DataContract]
    public class Move
    {
        [DataMember]
        public Position[] WallPlacementPositions { get; set; } = new Position[3];

        [DataMember]
        public bool IsWallPlacement { get; set; } = false;

        public bool IsMove { get { return !IsWallPlacement; } }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        [DataMember]
        public Position Destination { get; set; }

        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        [DataMember]
        public Player Player { get; set; }
    }
}