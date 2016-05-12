﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Transit.Framework;
using Transit.Framework.Texturing;

namespace Transit.Addon.RoadExtensions.Roads.PedestrianRoads.Gravel
{
    public partial class ZonablePedestrianGravelBuilder
    {
        private static void SetupTextures(NetInfo info, NetInfoVersion version)
        {
            switch (version)
            {
                case NetInfoVersion.Ground:
                    info.SetAllSegmentsTexture(
                        new TextureSet(
                            @"Roads\PedestrianRoads\Common\Textures\Ground_Segment__AlphaMap.png",
                            @"Roads\PedestrianRoads\Common\Textures\Ground_Segment__AlphaMap.png"),
                        new LODTextureSet(
                            @"Roads\PedestrianRoads\Common\Textures\Ground_Segment_LOD__AlphaMap.png",
                            @"Roads\PedestrianRoads\Common\Textures\Ground_Segment_LOD__AlphaMap.png",
                            @"Roads\PedestrianRoads\Common\Textures\Ground_Node_LOD__XYSMap.png"));

                    foreach (var node in info.m_nodes)
                    {
                        if (node.m_flagsRequired != NetNode.Flags.Transition)
                        {
                            node.SetTextures(
                                new TextureSet
                                    (@"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Node__MainTex.png",
                                        @"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Node__AlphaMap.png",
                                        @"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Node__XYSMap.png"),
                                new LODTextureSet
                                    (@"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Node_LOD__MainTex.png",
                                     @"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Node_LOD__AlphaMap.png",
                                     @"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Node_LOD__XYSMap.png"));
                        }
                        else
                        {
                            node.SetTextures(
                                new TextureSet
                                    (@"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Trans__MainTex.png",
                                     @"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Trans__AlphaMap.png",
                                     @"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Node__XYSMap.png"),
                                new LODTextureSet
                                    (@"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Trans_LOD__MainTex.png",
                                    @"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Trans_LOD__AlphaMap.png",
                                    @"Roads\PedestrianRoads\StoneSmall\Textures\Ground_Node_LOD__XYSMap.png"));
                        }
                    }
                    break;
                case NetInfoVersion.Elevated:
                    info.SetAllSegmentsTexture(
                        new TextureSet(
                            @"Roads\PedestrianRoads\BoardwalkSmall\Textures\Elevated_Segment__MainTex.png",
                            @"Roads\PedestrianRoads\BoardwalkSmall\Textures\Elevated_Segment__AlphaMap.png",
                            @"Roads\PedestrianRoads\BoardwalkSmall\Textures\Elevated_Segment__XYSMap.png"));

                    foreach (var node in info.m_nodes)
                    {
                        if (node.m_flagsRequired != NetNode.Flags.Transition)
                        {
                            node.SetTextures(
                                new TextureSet(
                                    @"Roads\PedestrianRoads\BoardwalkSmall\Textures\Elevated_Segment__MainTex.png",
                                    @"Roads\PedestrianRoads\BoardwalkSmall\Textures\Elevated_Segment__AlphaMap.png",
                                    @"Roads\PedestrianRoads\BoardwalkSmall\Textures\Elevated_Segment__XYSMap.png"));
                        }
                        else
                        {
                            node.SetTextures(
                                new TextureSet
                                    (@"Roads\PedestrianRoads\StoneSmall\Textures\Elevated_Trans__MainTex.png",
                                        @"Roads\PedestrianRoads\StoneSmall\Textures\Elevated_Trans__AlphaMap.png"));
                        }
                    }
                    //new LODTextureSet(
                    //    @"Roads\PedestrianRoads\Common\Textures\Ground_Segment_LOD__AlphaMap.png",
                    //    @"Roads\PedestrianRoads\Common\Textures\Ground_Segment_LOD__AlphaMap.png",
                    //    @"Roads\PedestrianRoads\Common\Textures\Ground_Node_LOD__XYSMap.png"));
                    break;
            }
        }
    }
}
