using EssentialJS2WebApplicationDiagram.Controllers;
using Syncfusion.EJ2.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncFusionWebDiagram.AppCode
{
    public static class FlowChartDiagram
    {
        public static List<SymbolPalettePalette> getSymbolPalettePalettes()
        {
            List<DiagramNode> SymbolPaletee = new List<DiagramNode>();
            SymbolPaletee.Add(new FlowShapes() { Id = "Terminator", Shape = new { type = "Flow", shape = "Terminator" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Process", Shape = new { type = "Flow", shape = "Process" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Decision", Shape = new { type = "Flow", shape = "Decision" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Document", Shape = new { type = "Flow", shape = "Document" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "PreDefinedProcess", Shape = new { type = "Flow", shape = "PreDefinedProcess" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "PaperTap", Shape = new { type = "Flow", shape = "PaperTap" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "DirectData", Shape = new { type = "Flow", shape = "DirectData" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "SequentialData", Shape = new { type = "Flow", shape = "SequentialData" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Sort", Shape = new { type = "Flow", shape = "Sort" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "MultiDocument", Shape = new { type = "Flow", shape = "MultiDocument" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Collate", Shape = new { type = "Flow", shape = "Collate" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "SummingJunction", Shape = new { type = "Flow", shape = "SummingJunction" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Or", Shape = new { type = "Flow", shape = "Or" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "InternalStorage", Shape = new { type = "Flow", shape = "InternalStorage" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Extract", Shape = new { type = "Flow", shape = "Extract" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "ManualOperation", Shape = new { type = "Flow", shape = "ManualOperation" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Merge", Shape = new { type = "Flow", shape = "Merge" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "OffPageReference", Shape = new { type = "Flow", shape = "OffPageReference" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "SequentialAccessStorage", Shape = new { type = "Flow", shape = "SequentialAccessStorage" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Annotation", Shape = new { type = "Flow", shape = "Annotation" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Annotation2", Shape = new { type = "Flow", shape = "Annotation2" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Data", Shape = new { type = "Flow", shape = "Data" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Card", Shape = new { type = "Flow", shape = "Card" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Delay", Shape = new { type = "Flow", shape = "Delay" } });
            List<DiagramConnector> SymbolPaletteConnectors = new List<DiagramConnector>();
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link1",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link2",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link3",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link4",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link5",
                Type = Segments.Bezier,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            List<SymbolPalettePalette> Palette = new List<SymbolPalettePalette>
            {
                new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = SymbolPaletee, IconCss = "e-ddb-icons e-flow", Title = "Flow Shapes" },
                new SymbolPalettePalette() { Id = "connectors", Expanded = true, Symbols = SymbolPaletteConnectors, IconCss = "e-ddb-icons e-connector", Title = "Connectors" }
            };

            return Palette;
        }
    }
}
