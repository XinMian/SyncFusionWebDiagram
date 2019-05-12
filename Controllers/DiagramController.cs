using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using Syncfusion.EJ2.Diagrams;
using SyncFusionWebDiagram.AppCode;
using Newtonsoft.Json;

namespace EssentialJS2WebApplicationDiagram.Controllers
{
    public partial class DiagramController : Controller
    {
        // GET: /<controller>/
        public ActionResult DiagramFeatures()
        {
            List<DiagramNode> Nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "Place Order", Style = new DiagramTextStyle() { Color = "Black", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Start Transaction", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "Verification", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Credit Card ValId?", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "Funds Available", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node6 = new List<DiagramNodeAnnotation>();
            Node6.Add(new DiagramNodeAnnotation() { Content = "Enter Payment Method", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node7 = new List<DiagramNodeAnnotation>();
            Node7.Add(new DiagramNodeAnnotation() { Content = "Log Transaction", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node8 = new List<DiagramNodeAnnotation>();
            Node8.Add(new DiagramNodeAnnotation() { Content = "Reconcile the entries", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node9 = new List<DiagramNodeAnnotation>();
            Node9.Add(new DiagramNodeAnnotation() { Content = "Complete Transaction", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node10 = new List<DiagramNodeAnnotation>();
            Node10.Add(new DiagramNodeAnnotation() { Content = "Send E-mail", Margin = new DiagramMargin() { Left = 25, Right = 25 }, Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramNodeAnnotation> Node11 = new List<DiagramNodeAnnotation>();
            Node11.Add(new DiagramNodeAnnotation() { Content = "Customer Database", Margin = new DiagramMargin() { Left = 25, Right = 25 }, Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramConnectorAnnotation> Connector1 = new List<DiagramConnectorAnnotation>();
            Connector1.Add(new DiagramConnectorAnnotation() { Content = "Yes", Style = new DiagramTextStyle() { Fill = "White" } });
            List<DiagramConnectorAnnotation> Connector2 = new List<DiagramConnectorAnnotation>();
            Connector2.Add(new DiagramConnectorAnnotation() { Content = "Yes", Style = new DiagramTextStyle() { Fill = "White" } });
            List<DiagramConnectorAnnotation> Connector3 = new List<DiagramConnectorAnnotation>();
            Connector3.Add(new DiagramConnectorAnnotation() { Content = "No", Style = new DiagramTextStyle() { Fill = "White" } });
            Nodes.Add(new DefaultNode()
            {
                Id = "NewIdea",
                OffsetY = 80,
                OffsetX = 500,
                Height = 60,
                Annotations = Node1,
                Shape = new { type = "Flow", shape = "Terminator" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "Meeting",
                OffsetX = 340,
                OffsetY = 160,
                Height = 60,
                Annotations = Node2,
                Shape = new { type = "Flow", shape = "Process" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "BoardDecision",
                OffsetX = 340,
                OffsetY = 240,
                Height = 60,
                Annotations = Node3,
                Shape = new { type = "Flow", shape = "Process" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "Project",
                OffsetX = 340,
                OffsetY = 330,
                Height = 60,
                Annotations = Node4,
                Shape = new { type = "Flow", shape = "Decision" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "End",
                OffsetY = 430,
                OffsetX = 340,
                Height = 60,
                Annotations = Node5,
                Shape = new { type = "Flow", shape = "Decision" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "node11",
                OffsetY = 330,
                OffsetX = 550,
                Height = 60,
                Annotations = Node6,
                Shape = new { type = "Flow", shape = "Process" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "transaction_entered",
                OffsetY = 630,
                OffsetX = 340,
                Height = 60,
                Annotations = Node7,
                Shape = new { type = "Flow", shape = "Terminator" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "node12",
                OffsetY = 630,
                OffsetX = 550,
                Height = 60,
                Annotations = Node8,
                Shape = new { type = "Flow", shape = "Process" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "transaction_completed",
                OffsetY = 530,
                OffsetX = 340,
                Height = 60,
                Annotations = Node9,
                Shape = new { type = "Flow", shape = "Process" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "Data",
                OffsetY = 530,
                OffsetX = 120,
                Height = 60,
                Annotations = Node10,
                Shape = new { type = "Flow", shape = "Data" }
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "node10",
                OffsetY = 530,
                OffsetX = 550,
                Height = 60,
                Annotations = Node11,
                Shape = new { type = "Flow", shape = "DirectData" }
            });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "NewIdea", TargetID = "Meeting", });
            Connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "Meeting", TargetID = "BoardDecision" });
            Connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "BoardDecision", TargetID = "Project" });
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector4",
                SourceID = "Project",
                TargetID = "End",
                Annotations = Connector1
            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector5",
                SourceID = "End",
                TargetID = "transaction_completed",
                Annotations = Connector2
            });
            Connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "transaction_completed", TargetID = "transaction_entered" });
            Connectors.Add(new DiagramConnector() { Id = "connector7", SourceID = "transaction_completed", TargetID = "Data" });
            Connectors.Add(new DiagramConnector() { Id = "connector8", SourceID = "transaction_completed", TargetID = "node10" });
            Connectors.Add(new DiagramConnector() { Id = "connector9", SourceID = "node11", TargetID = "Meeting" });
            Connectors.Add(new DiagramConnector() { Id = "connector10", SourceID = "End", TargetID = "node11" });
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector11",
                SourceID = "Project",
                TargetID = "node11",
                Annotations = Connector3
            });
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector12",
                SourceID = "transaction_entered",
                TargetID = "node12",
                Style = new DiagramStrokeStyle() { StrokeDashArray = "2,2" }
            });
            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;
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
            double[] intervals = { 1, 9, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75 };
            DiagramGridlines grIdLines = new DiagramGridlines()
            { LineColor = "#e0e0e0", LineIntervals = intervals };
            ViewBag.gridLines = grIdLines;
            DiagramMargin margin = new DiagramMargin() { Left = 15, Right = 15, Bottom = 15, Top = 15 };
            ViewBag.margin = margin;
            //ViewBag.Palette = Palette;
            ViewBag.Multiple = "Multiple";
            ViewBag.getSymbolNode = "getSymbolNodes";
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            ViewBag.getSymbolInfo = "getSymbolInfo";
            return View();
        }

        public ActionResult DiagramGrade()
        {
            List<DiagramNode> Nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> NodeStart = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeInput = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDecision80 = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDecision75 = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDecision70 = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDecision65 = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDecision60 = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDecision55 = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDecision50 = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDecisionLess50 = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeA = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeBp = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeB = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeCp = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeC = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeDp = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeD = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeF = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeOutput = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeCircle = new List<DiagramNodeAnnotation>();
            List<DiagramNodeAnnotation> NodeEnd = new List<DiagramNodeAnnotation>();


            NodeStart.Add(new DiagramNodeAnnotation() { Content = "Start", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeInput.Add(new DiagramNodeAnnotation() { Content = "Input Score", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeDecision80.Add(new DiagramNodeAnnotation() { Content = "Score >= 80", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeDecision75.Add(new DiagramNodeAnnotation() { Content = "Score >= 75", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeDecision70.Add(new DiagramNodeAnnotation() { Content = "Score >= 70", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeDecision65.Add(new DiagramNodeAnnotation() { Content = "Score >= 65", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeDecision60.Add(new DiagramNodeAnnotation() { Content = "Score >= 60", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeDecision55.Add(new DiagramNodeAnnotation() { Content = "Score >= 55", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeDecision50.Add(new DiagramNodeAnnotation() { Content = "Score >= 50", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeA.Add(new DiagramNodeAnnotation() { Content = "Grade = A", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeBp.Add(new DiagramNodeAnnotation() { Content = "Grade = B+", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeB.Add(new DiagramNodeAnnotation() { Content = "Grade = B", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeCp.Add(new DiagramNodeAnnotation() { Content = "Grade = C+", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeC.Add(new DiagramNodeAnnotation() { Content = "Grade = C", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeDp.Add(new DiagramNodeAnnotation() { Content = "Grade = D+", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeD.Add(new DiagramNodeAnnotation() { Content = "Grade = D", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeF.Add(new DiagramNodeAnnotation() { Content = "Grade = F", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeOutput.Add(new DiagramNodeAnnotation() { Content = "Grade", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            NodeEnd.Add(new DiagramNodeAnnotation() { Content = "End", Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });

            Nodes.Add(new DefaultNode() { Id = "Start", OffsetX = 340, OffsetY = 100, Height = 60, Annotations = NodeStart, Shape = new { type = "Flow", shape = "Terminator" }, Style = new DiagramStrokeStyle() { Fill = "Red"} });
            Nodes.Add(new DefaultNode() { Id = "Input", OffsetX = 340, OffsetY = 200, Height = 60, Annotations = NodeInput, Shape = new { type = "Flow", shape = "Data" } });
            Nodes.Add(new DefaultNode() { Id = "Decision80", OffsetX = 340, OffsetY = 300, Height = 60, Annotations = NodeDecision80, Shape = new { type = "Flow", shape = "Decision" } });
            Nodes.Add(new DefaultNode() { Id = "Decision75", OffsetX = 340, OffsetY = 400, Height = 60, Annotations = NodeDecision75, Shape = new { type = "Flow", shape = "Decision" } });
            Nodes.Add(new DefaultNode() { Id = "Decision70", OffsetX = 340, OffsetY = 500, Height = 60, Annotations = NodeDecision70, Shape = new { type = "Flow", shape = "Decision" } });
            Nodes.Add(new DefaultNode() { Id = "Decision65", OffsetX = 340, OffsetY = 600, Height = 60, Annotations = NodeDecision65, Shape = new { type = "Flow", shape = "Decision" } });
            Nodes.Add(new DefaultNode() { Id = "Decision60", OffsetX = 340, OffsetY = 700, Height = 60, Annotations = NodeDecision60, Shape = new { type = "Flow", shape = "Decision" } });
            Nodes.Add(new DefaultNode() { Id = "Decision55", OffsetX = 340, OffsetY = 800, Height = 60, Annotations = NodeDecision55, Shape = new { type = "Flow", shape = "Decision" } });
            Nodes.Add(new DefaultNode() { Id = "Decision50", OffsetX = 340, OffsetY = 900, Height = 60, Annotations = NodeDecision50, Shape = new { type = "Flow", shape = "Decision" } });
            Nodes.Add(new DefaultNode() { Id = "A", OffsetX = 600, OffsetY = 300, Height = 60, Annotations = NodeA, Shape = new { type = "Flow", shape = "Process" } });
            Nodes.Add(new DefaultNode() { Id = "Bp", OffsetX = 600, OffsetY = 400, Height = 60, Annotations = NodeBp, Shape = new { type = "Flow", shape = "Process" } });
            Nodes.Add(new DefaultNode() { Id = "B", OffsetX = 600, OffsetY = 500, Height = 60, Annotations = NodeB, Shape = new { type = "Flow", shape = "Process" } });
            Nodes.Add(new DefaultNode() { Id = "Cp", OffsetX = 600, OffsetY = 600, Height = 60, Annotations = NodeCp, Shape = new { type = "Flow", shape = "Process" } });
            Nodes.Add(new DefaultNode() { Id = "C", OffsetX = 600, OffsetY = 700, Height = 60, Annotations = NodeC, Shape = new { type = "Flow", shape = "Process" } });
            Nodes.Add(new DefaultNode() { Id = "Dp", OffsetX = 600, OffsetY = 800, Height = 60, Annotations = NodeDp, Shape = new { type = "Flow", shape = "Process" } });
            Nodes.Add(new DefaultNode() { Id = "D", OffsetX = 600, OffsetY = 900, Height = 60, Annotations = NodeD, Shape = new { type = "Flow", shape = "Process" } });
            Nodes.Add(new DefaultNode() { Id = "F", OffsetX = 340, OffsetY = 1000, Height = 60, Annotations = NodeF, Shape = new { type = "Flow", shape = "Process" } });
            Nodes.Add(new DefaultNode() { Id = "Output", OffsetX = 340, OffsetY = 1100, Height = 60, Annotations = NodeOutput, Shape = new { type = "Flow", shape = "Data" } });
            Nodes.Add(new DefaultNode() { Id = "Circle", OffsetX = 700, OffsetY = 1100, Height = 20, Width = 20 , Annotations = NodeCircle, Shape = new { type = "Flow", shape = "SequentialData" } });
            Nodes.Add(new DefaultNode() { Id = "End", OffsetX = 340, OffsetY = 1200, Height = 60, Annotations = NodeEnd, Shape = new { type = "Flow", shape = "Terminator" } });

            List<DiagramConnectorAnnotation> ConnectorYes = new List<DiagramConnectorAnnotation>();
            ConnectorYes.Add(new DiagramConnectorAnnotation() { Content = "Yes", Style = new DiagramTextStyle() { Fill = "White" } });
            List<DiagramConnectorAnnotation> ConnectorNo = new List<DiagramConnectorAnnotation>();
            ConnectorNo.Add(new DiagramConnectorAnnotation() { Content = "No", Style = new DiagramTextStyle() { Fill = "White" } });

            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "Start", TargetID = "Input" });
            Connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "Input", TargetID = "Decision80" });
            Connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "Decision80", TargetID = "Decision75", Annotations = ConnectorNo });
            Connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "Decision75", TargetID = "Decision70", Annotations = ConnectorNo });
            Connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "Decision70", TargetID = "Decision65", Annotations = ConnectorNo });
            Connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "Decision65", TargetID = "Decision60", Annotations = ConnectorNo });
            Connectors.Add(new DiagramConnector() { Id = "connector7", SourceID = "Decision60", TargetID = "Decision55", Annotations = ConnectorNo });
            Connectors.Add(new DiagramConnector() { Id = "connector8", SourceID = "Decision55", TargetID = "Decision50", Annotations = ConnectorNo });
            Connectors.Add(new DiagramConnector() { Id = "connector10", SourceID = "Decision80", TargetID = "A", Annotations = ConnectorYes });
            Connectors.Add(new DiagramConnector() { Id = "connector11", SourceID = "Decision75", TargetID = "Bp", Annotations = ConnectorYes });
            Connectors.Add(new DiagramConnector() { Id = "connector12", SourceID = "Decision70", TargetID = "B", Annotations = ConnectorYes });
            Connectors.Add(new DiagramConnector() { Id = "connector13", SourceID = "Decision65", TargetID = "Cp", Annotations = ConnectorYes });
            Connectors.Add(new DiagramConnector() { Id = "connector14", SourceID = "Decision60", TargetID = "C", Annotations = ConnectorYes });
            Connectors.Add(new DiagramConnector() { Id = "connector15", SourceID = "Decision55", TargetID = "Dp", Annotations = ConnectorYes });
            Connectors.Add(new DiagramConnector() { Id = "connector16", SourceID = "Decision50", TargetID = "D", Annotations = ConnectorYes });
            Connectors.Add(new DiagramConnector() { Id = "connector17", SourceID = "Decision50", TargetID = "F", Annotations = ConnectorNo });
            Connectors.Add(new DiagramConnector() { Id = "connector18", SourceID = "F", TargetID = "Output" });
            Connectors.Add(new DiagramConnector() { Id = "connector19", SourceID = "A", TargetID = "Circle" });
            Connectors.Add(new DiagramConnector() { Id = "connector20", SourceID = "Bp", TargetID = "Circle" });
            Connectors.Add(new DiagramConnector() { Id = "connector21", SourceID = "B", TargetID = "Circle" });
            Connectors.Add(new DiagramConnector() { Id = "connector22", SourceID = "Cp", TargetID = "Circle" });
            Connectors.Add(new DiagramConnector() { Id = "connector23", SourceID = "C", TargetID = "Circle" });
            Connectors.Add(new DiagramConnector() { Id = "connector24", SourceID = "Dp", TargetID = "Circle" });
            Connectors.Add(new DiagramConnector() { Id = "connector25", SourceID = "D", TargetID = "Circle" });
            Connectors.Add(new DiagramConnector() { Id = "connector26", SourceID = "Circle", TargetID = "Output" });
            Connectors.Add(new DiagramConnector() { Id = "connector27", SourceID = "Output", TargetID = "End" });

            ViewBag.nodesJson = JsonConvert.SerializeObject(Nodes,Newtonsoft.Json.Formatting.None,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });
            ViewBag.connectorsJson = JsonConvert.SerializeObject(Connectors, Newtonsoft.Json.Formatting.None,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });
            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;


            ViewBag.Palette = FlowChartDiagram.getSymbolPalettePalettes();
            ViewBag.Multiple = "Multiple";
            ViewBag.getSymbolNode = "getSymbolNodes";
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            ViewBag.getSymbolInfo = "getSymbolInfo";
            return View();
        }

        public ActionResult NewDiagram()
        {
            ViewBag.nodes = new List<DiagramNode>();
            ViewBag.connectors = new List<DiagramConnector>();
            ViewBag.Palette = FlowChartDiagram.getSymbolPalettePalettes();
            ViewBag.Multiple = "Multiple";
            ViewBag.getSymbolNode = "getSymbolNodes";
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            ViewBag.getSymbolInfo = "getSymbolInfo";

            return View();
        }
    }
    public class DefaultNode : DiagramNode
    {
        public DefaultNode()
        {
            this.Height = 60;
        }
    }
    public class AnnotationAppearance : DiagramNodeAnnotation
    {
        public AnnotationAppearance()
        {
            this.Style = new DiagramTextStyle() { Color = "white" };
        }
    }
    public class FlowShapes : DiagramNode
    {
        public FlowShapes()
        {
        }
    }

    
}
