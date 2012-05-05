﻿/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using SteamKit2.Internal;

namespace SteamKit2.GC
{
    /// <summary>
    /// Represents a unified interface into client messages.
    /// </summary>
    public interface IClientGCMsg
    {
        /// <summary>
        /// Gets a value indicating whether this client message is protobuf backed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is protobuf backed; otherwise, <c>false</c>.
        /// </value>
        bool IsProto { get; }
        /// <summary>
        /// Gets the network message type of this client message.
        /// </summary>
        /// <value>
        /// The message type.
        /// </value>
        uint MsgType { get; }

        /// <summary>
        /// Gets or sets the session id for this client message.
        /// </summary>
        /// <value>
        /// The session id.
        /// </value>
        int SessionID { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="SteamID"/> for this client message.
        /// </summary>
        /// <value>
        /// The <see cref="SteamID"/>.
        /// </value>
        SteamID SteamID { get; set; }

        /// <summary>
        /// Gets or sets the target job id for this client message.
        /// </summary>
        /// <value>
        /// The target job id.
        /// </value>
        ulong TargetJobID { get; set; }
        /// <summary>
        /// Gets or sets the source job id for this client message.
        /// </summary>
        /// <value>
        /// The source job id.
        /// </value>
        ulong SourceJobID { get; set; }

        /// <summary>
        /// Serializes this client message instance to a byte array.
        /// </summary>
        /// <returns>Data representing a client message.</returns>
        byte[] Serialize();
        /// <summary>
        /// Initializes this client message by deserializing the specified data.
        /// </summary>
        /// <param name="data">The data representing a client message.</param>
        void Deserialize( byte[] data );
    }

    /// <summary>
    /// This is the abstract base class for all available client messages.
    /// It's used to maintain packet payloads and provide a header for all client messages.
    /// </summary>
    /// <typeparam name="HdrType">The header type for this client message.</typeparam>
    public abstract class GCMsgBase<HdrType> : MsgBase, IClientGCMsg
        where HdrType : IGCSerializableHeader, new()
    {
        /// <summary>
        /// Gets a value indicating whether this client message is protobuf backed.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is protobuf backed; otherwise, <c>false</c>.
        /// </value>
        public abstract bool IsProto { get; }
        /// <summary>
        /// Gets the network message type of this client message.
        /// </summary>
        /// <value>
        /// The network message type.
        /// </value>
        public abstract uint MsgType { get; }

        /// <summary>
        /// Gets or sets the session id for this client message.
        /// </summary>
        /// <value>
        /// The session id.
        /// </value>
        public abstract int SessionID { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="SteamID"/> for this client message.
        /// </summary>
        /// <value>
        /// The <see cref="SteamID"/>.
        /// </value>
        public abstract SteamID SteamID { get; set; }

        /// <summary>
        /// Gets or sets the target job id for this client message.
        /// </summary>
        /// <value>
        /// The target job id.
        /// </value>
        public abstract ulong TargetJobID { get; set; }
        /// <summary>
        /// Gets or sets the source job id for this client message.
        /// </summary>
        /// <value>
        /// The source job id.
        /// </value>
        public abstract ulong SourceJobID { get; set; }


        /// <summary>
        /// Gets the header for this message type. 
        /// </summary>
        public HdrType Header { get; private set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="MsgBase&lt;HdrType&gt;"/> class.
        /// </summary>
        /// <param name="payloadReserve">The number of bytes to initialize the payload capacity to.</param>
        public GCMsgBase( int payloadReserve = 0 )
            : base( payloadReserve )
        {
            Header = new HdrType();
        }


        /// <summary>
        /// Serializes this client message instance to a byte array.
        /// </summary>
        /// <returns>
        /// Data representing a client message.
        /// </returns>
        public abstract byte[] Serialize();
        /// <summary>
        /// Initializes this client message by deserializing the specified data.
        /// </summary>
        /// <param name="data">The data representing a client message.</param>
        public abstract void Deserialize( byte[] data );

    }
}
