﻿using Transit.Framework;

namespace Transit.Addon.RoadExtensions.Roads.SmallHeavyRoads.BasicRoadTL
{
    public partial class BasicRoadTLBuilder
    {
        private static void SetupTextures(NetInfo info, NetInfoVersion version)
        {
            switch (version)
            {
                case NetInfoVersion.Ground:
                    info.SetAllSegmentsTexture(
                        new TexturesSet
                            (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_Segment__MainTex.png",
                            @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_Segment__AlphaMap.png"),
                        new LODTexturesSet
                            (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_SegmentLOD__MainTex.png",
                            @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_SegmentLOD__AlphaMap.png",
                            @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_SegmentLOD__XYS.png"));
                    break;
                case NetInfoVersion.Elevated:
                case NetInfoVersion.Bridge:
                    info.SetAllSegmentsTexture(
                        new TexturesSet
                            (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_MainTex.png",
                            @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_Segment__APRMap.png"),
						new LODTexturesSet
							(@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_LOD__MainTex.png",
							@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_SegmentLOD__APRMap.png",
							@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_LOD__XYSMap.png"));
					info.SetAllNodesTexture(
                        new TexturesSet
                            (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_MainTex.png",
                            @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_Node__APRMap.png"),
                        new LODTexturesSet
                            (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_LOD__MainTex.png",
                            @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_NodeLOD__APRMap.png",
                            @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Elevated_LOD__XYSMap.png"));
                    break;
                case NetInfoVersion.Slope:
                    for (int i = 0; i < info.m_segments.Length; i++)
                    {
                        if (info.m_segments[i].m_mesh.name == "Slope")
                        {
                            info.m_segments[i].SetTextures(
                                new TexturesSet
                                    (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_Segment__AlphaMap.png"),
                                new LODTexturesSet
                                    (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_SegmentLOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_SegmentLOD__AlphaMap.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Slope_SegmentLOD2__XYSMap.png"));
                        }
                        else
                        {
                            info.m_segments[i].SetTextures(
                                new TexturesSet
                                   (@"Roads\Highways\Highway4L\Textures\Slope_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Slope_Segment__APRMap.png"),
                                new LODTexturesSet
                                    (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Slope_SegmentLOD__MainTex.png",
                                     @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Slope_SegmentLOD__APRMap.png",
                                     @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Slope_SegmentLOD__XYSMap.png"));
                        }
                    }
                    for (int i = 0; i < info.m_nodes.Length; i++)
                    {
                        if (info.m_nodes[i].m_mesh.name == "Slope_Node")
                        {
                            info.m_nodes[i].SetTextures(
                                new TexturesSet
                                    (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_Node__AlphaMap.png"),
                                new LODTexturesSet
                                    (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_SegmentLOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_SegmentLOD__AlphaMap.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Ground_SegmentLOD__XYS.png"));
                        }
                        else
                        {
                            info.m_nodes[i].SetTextures(
                                new TexturesSet
                                    (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_Segment__MainTex.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_Node__APRMap.png"),
                                new LODTexturesSet
                                    (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_NodeLOD__MainTex.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_LOD__APRMap.png",
                                    @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_LOD__XYSMap.png"));
                        }
                    }
                        //info.SetAllNodesTexture(
                        //new TexturesSet
                        //    (@"Roads\Highways\Highway4L\Textures\Slope_Node__MainTex.png",
                        //    @"Roads\Highways\Highway4L\Textures\Ground_Node__APRMap.png"),
                        //new LODTexturesSet
                        //    (@"Roads\Highways\Highway4L\Textures\Ground_NodeLOD__MainTex.png",
                        //    @"Roads\Highways\Highway4L\Textures\Ground_NodeLOD__APRMap.png",
                        //    @"Roads\Highways\Highway4L\Textures\Ground_LOD__XYSMap.png"));
                    break;
                case NetInfoVersion.Tunnel:
                    {
                        info.SetAllSegmentsTexture(
                            new TexturesSet
                                (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_Segment__MainTex.png",
                                @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_Segment__APRMap.png"),
                            new LODTexturesSet
                                (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_NodeLOD__MainTex.png",
                                @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_LOD__APRMap.png",
                                @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_LOD__XYSMap.png"));
                        info.SetAllNodesTexture(
                            new TexturesSet
                                (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_Segment__MainTex.png",
                                @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_Node__APRMap.png"),
                            new LODTexturesSet
                                (@"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_NodeLOD__MainTex.png",
                                @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_LOD__APRMap.png",
                                @"Roads\SmallHeavyRoads\BasicRoadTL\Textures\Tunnel_LOD__XYSMap.png"));
                        break;
                    }
            }
        }
    }
}
