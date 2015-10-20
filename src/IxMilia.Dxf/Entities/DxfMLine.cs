// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Entities
{

    /// <summary>
    /// DxfMLine class
    /// </summary>
    public partial class DxfMLine : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.MLine; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R13; } }

        public string StyleName { get; set; }
        public uint StyleHandle { get; set; }
        public double ScaleFactor { get; set; }
        public DxfJustification Justification { get; set; }
        public int Flags { get; set; }
        private int VertexCount { get; set; }
        public int StyleElementCount { get; set; }
        public DxfPoint StartPoint { get; set; }
        public DxfVector Normal { get; set; }
        private List<double> VertexX { get; set; }
        private List<double> VertexY { get; set; }
        private List<double> VertexZ { get; set; }
        private List<double> SegmentDirectionX { get; set; }
        private List<double> SegmentDirectionY { get; set; }
        private List<double> SegmentDirectionZ { get; set; }
        private List<double> MiterDirectionX { get; set; }
        private List<double> MiterDirectionY { get; set; }
        private List<double> MiterDirectionZ { get; set; }
        private int ParameterCount { get; set; }
        public List<double> Parameters { get; set; }
        private int AreaFillParameterCount { get; set; }
        public List<double> AreaFillParameters { get; set; }

        // Flags flags

        public bool HasAtLeastOneVertex
        {
            get { return DxfHelpers.GetFlag(Flags, 1); }
            set
            {
                var flags = Flags;
                DxfHelpers.SetFlag(value, ref flags, 1);
                Flags = flags;
            }
        }

        public bool IsClosed
        {
            get { return DxfHelpers.GetFlag(Flags, 2); }
            set
            {
                var flags = Flags;
                DxfHelpers.SetFlag(value, ref flags, 2);
                Flags = flags;
            }
        }

        public bool SuppressStartCaps
        {
            get { return DxfHelpers.GetFlag(Flags, 4); }
            set
            {
                var flags = Flags;
                DxfHelpers.SetFlag(value, ref flags, 4);
                Flags = flags;
            }
        }

        public bool SuppressEndCaps
        {
            get { return DxfHelpers.GetFlag(Flags, 8); }
            set
            {
                var flags = Flags;
                DxfHelpers.SetFlag(value, ref flags, 8);
                Flags = flags;
            }
        }

        public DxfMLine()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.StyleName = null;
            this.StyleHandle = 0;
            this.ScaleFactor = 1.0;
            this.Justification = DxfJustification.Top;
            this.Flags = 0;
            this.VertexCount = 0;
            this.StyleElementCount = 0;
            this.StartPoint = DxfPoint.Origin;
            this.Normal = DxfVector.ZAxis;
            this.VertexX = new List<double>();
            this.VertexY = new List<double>();
            this.VertexZ = new List<double>();
            this.SegmentDirectionX = new List<double>();
            this.SegmentDirectionY = new List<double>();
            this.SegmentDirectionZ = new List<double>();
            this.MiterDirectionX = new List<double>();
            this.MiterDirectionY = new List<double>();
            this.MiterDirectionZ = new List<double>();
            this.ParameterCount = 0;
            this.Parameters = new List<double>();
            this.AreaFillParameterCount = 0;
            this.AreaFillParameters = new List<double>();
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbMline"));
            pairs.Add(new DxfCodePair(2, (this.StyleName)));
            pairs.Add(new DxfCodePair(340, UIntHandle(this.StyleHandle)));
            pairs.Add(new DxfCodePair(40, (this.ScaleFactor)));
            pairs.Add(new DxfCodePair(70, (short)(this.Justification)));
            pairs.Add(new DxfCodePair(71, (short)(this.Flags)));
            pairs.Add(new DxfCodePair(72, (short)Vertices.Count));
            pairs.Add(new DxfCodePair(73, (short)(this.StyleElementCount)));
            pairs.Add(new DxfCodePair(10, StartPoint?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, StartPoint?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(30, StartPoint?.Z ?? default(double)));
            if (this.Normal != DxfVector.ZAxis)
            {
                pairs.Add(new DxfCodePair(210, Normal?.X ?? default(double)));
                pairs.Add(new DxfCodePair(220, Normal?.Y ?? default(double)));
                pairs.Add(new DxfCodePair(230, Normal?.Z ?? default(double)));
            }

            if (Vertices != null)
            {
                foreach (var item in Vertices)
                {
                    pairs.Add(new DxfCodePair(10, item.X));
                    pairs.Add(new DxfCodePair(20, item.Y));
                    pairs.Add(new DxfCodePair(30, item.Z));
                }
            }

            if (SegmentDirections != null)
            {
                foreach (var item in SegmentDirections)
                {
                    pairs.Add(new DxfCodePair(11, item.X));
                    pairs.Add(new DxfCodePair(21, item.Y));
                    pairs.Add(new DxfCodePair(31, item.Z));
                }
            }

            if (MiterDirections != null)
            {
                foreach (var item in MiterDirections)
                {
                    pairs.Add(new DxfCodePair(12, item.X));
                    pairs.Add(new DxfCodePair(22, item.Y));
                    pairs.Add(new DxfCodePair(32, item.Z));
                }
            }

            pairs.Add(new DxfCodePair(74, (short?)Parameters?.Count ?? default(short)));
            if (this.Parameters != null)
            {
                pairs.AddRange(this.Parameters.Select(p => new DxfCodePair(41, p)));
            }

            pairs.Add(new DxfCodePair(75, (short?)AreaFillParameters?.Count ?? default(short)));
            if (this.AreaFillParameters != null)
            {
                pairs.AddRange(this.AreaFillParameters.Select(p => new DxfCodePair(42, p)));
            }

        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 2:
                    this.StyleName = (pair.StringValue);
                    break;
                case 10:
                    this.StartPoint.X = pair.DoubleValue;
                    break;
                case 20:
                    this.StartPoint.Y = pair.DoubleValue;
                    break;
                case 30:
                    this.StartPoint.Z = pair.DoubleValue;
                    break;
                case 11:
                    this.VertexX.Add((pair.DoubleValue));
                    break;
                case 12:
                    this.SegmentDirectionX.Add((pair.DoubleValue));
                    break;
                case 13:
                    this.MiterDirectionX.Add((pair.DoubleValue));
                    break;
                case 21:
                    this.VertexY.Add((pair.DoubleValue));
                    break;
                case 22:
                    this.SegmentDirectionY.Add((pair.DoubleValue));
                    break;
                case 23:
                    this.MiterDirectionY.Add((pair.DoubleValue));
                    break;
                case 31:
                    this.VertexZ.Add((pair.DoubleValue));
                    break;
                case 32:
                    this.SegmentDirectionZ.Add((pair.DoubleValue));
                    break;
                case 33:
                    this.MiterDirectionZ.Add((pair.DoubleValue));
                    break;
                case 40:
                    this.ScaleFactor = (pair.DoubleValue);
                    break;
                case 41:
                    this.Parameters.Add((pair.DoubleValue));
                    break;
                case 42:
                    this.AreaFillParameters.Add((pair.DoubleValue));
                    break;
                case 70:
                    this.Justification = (DxfJustification)(pair.ShortValue);
                    break;
                case 71:
                    this.Flags = (int)(pair.ShortValue);
                    break;
                case 72:
                    this.VertexCount = (int)(pair.ShortValue);
                    break;
                case 73:
                    this.StyleElementCount = (int)(pair.ShortValue);
                    break;
                case 74:
                    this.ParameterCount = (int)(pair.ShortValue);
                    break;
                case 75:
                    this.AreaFillParameterCount = (int)(pair.ShortValue);
                    break;
                case 210:
                    this.Normal.X = pair.DoubleValue;
                    break;
                case 220:
                    this.Normal.Y = pair.DoubleValue;
                    break;
                case 230:
                    this.Normal.Z = pair.DoubleValue;
                    break;
                case 340:
                    this.StyleHandle = UIntHandle(pair.StringValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
