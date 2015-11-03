// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfRenderGlobal class
    /// </summary>
    public partial class DxfRenderGlobal : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.RenderGlobal; } }

        public int ClassVersion { get; set; }
        public DxfRenderProcedure RenderProcedure { get; set; }
        public DxfRenderDestination RenderDestination { get; set; }
        public bool SaveToFile { get; set; }
        public string SaveToFileName { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public bool UsePredefinedPresetsFirst { get; set; }
        public bool UseHighInfoLevel { get; set; }

        public DxfRenderGlobal()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.ClassVersion = 2;
            this.RenderProcedure = DxfRenderProcedure.View;
            this.RenderDestination = DxfRenderDestination.RenderWindow;
            this.SaveToFile = false;
            this.SaveToFileName = null;
            this.ImageWidth = 0;
            this.ImageHeight = 0;
            this.UsePredefinedPresetsFirst = false;
            this.UseHighInfoLevel = false;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbRenderGlobal"));
            pairs.Add(new DxfCodePair(90, (this.ClassVersion)));
            pairs.Add(new DxfCodePair(90, (int)(this.RenderProcedure)));
            pairs.Add(new DxfCodePair(90, (int)(this.RenderDestination)));
            pairs.Add(new DxfCodePair(290, (this.SaveToFile)));
            pairs.Add(new DxfCodePair(1, (this.SaveToFileName)));
            pairs.Add(new DxfCodePair(90, (this.ImageWidth)));
            pairs.Add(new DxfCodePair(90, (this.ImageHeight)));
            pairs.Add(new DxfCodePair(290, (this.UsePredefinedPresetsFirst)));
            pairs.Add(new DxfCodePair(290, (this.UseHighInfoLevel)));
        }

        // This object has vales that share codes between properties and these counters are used to know which property to
        // assign to in TrySetPair() below.
        private int _code_90_index = 0; // shared by properties ClassVersion, RenderProcedure, RenderDestination, ImageWidth, ImageHeight
        private int _code_290_index = 0; // shared by properties SaveToFile, UsePredefinedPresetsFirst, UseHighInfoLevel

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 1:
                    this.SaveToFileName = (pair.StringValue);
                    break;
                case 90:
                    switch (_code_90_index)
                    {
                        case 0:
                            this.ClassVersion = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 1:
                            this.RenderProcedure = (DxfRenderProcedure)(pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 2:
                            this.RenderDestination = (DxfRenderDestination)(pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 3:
                            this.ImageWidth = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        case 4:
                            this.ImageHeight = (pair.IntegerValue);
                            _code_90_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 90");
                            break;
                    }
                    break;
                case 290:
                    switch (_code_290_index)
                    {
                        case 0:
                            this.SaveToFile = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 1:
                            this.UsePredefinedPresetsFirst = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        case 2:
                            this.UseHighInfoLevel = (pair.BoolValue);
                            _code_290_index++;
                            break;
                        default:
                            Debug.Assert(false, "Unexpected extra values for code 290");
                            break;
                    }
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
