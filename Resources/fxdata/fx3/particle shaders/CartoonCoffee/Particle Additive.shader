Shader "CartoonCoffee/Particle Additive" {
	Properties {
		_TintColor ("Tint Color", Vector) = (0.5,0.5,0.5,0.5)
		_MainTex ("Particle Texture", 2D) = "white" {}
		_InvFade ("Soft Particles Factor", Range(0.01, 3)) = 1
		_NoiseTexture ("Noise Texture", 2D) = "white" {}
		[Toggle(_ENABLEADJUSTCOLOR_ON)] _EnableAdjustColor ("Enable Adjust Color", Float) = 0
		_AdjustColorFade ("Adjust Color: Fade", Range(0, 1)) = 1
		_AdjustColorBrightness ("Adjust Color: Brightness", Float) = 1
		_AdjustColorContrast ("Adjust Color: Contrast", Float) = 1
		_AdjustColorSaturation ("Adjust Color: Saturation", Float) = 1
		_AdjustColorHueShift ("Adjust Color: Hue Shift", Range(0, 1)) = 0
		[Toggle(_ENABLECUSTOMFADE_ON)] _EnableCustomFade ("Enable Custom Fade", Float) = 0
		_CustomFadeFadeMask ("Custom Fade: Fade Mask", 2D) = "white" {}
		_CustomFadeSmoothness ("Custom Fade: Smoothness", Float) = 2
		_CustomFadeNoiseScale ("Custom Fade: Noise Scale", Vector) = (1,1,0,0)
		_CustomFadeNoiseFactor ("Custom Fade: Noise Factor", Range(0, 0.5)) = 0
		_CustomFadeAlpha ("Custom Fade: Alpha", Range(0, 1)) = 1
		_CustomFadeBrightness ("Custom Fade: Brightness", Float) = 1
		[HDR] _CustomFadeAddColor ("Custom Fade: Add Color", Vector) = (0,0,0,0)
		[Toggle(_ENABLEBLACKTINT_ON)] _EnableBlackTint ("Enable Black Tint", Float) = 0
		_BlackTintFade ("Black Tint: Fade", Range(0, 1)) = 1
		[HDR] _BlackTintColor ("Black Tint: Color", Vector) = (1,0,0,0)
		_BlackTintPower ("Black Tint: Power", Float) = 2
		[Toggle(_ENABLEALPHATINT_ON)] _EnableAlphaTint ("Enable Alpha Tint", Float) = 0
		_AlphaTintFade ("Alpha Tint: Fade", Range(0, 1)) = 1
		[HDR] _AlphaTintColor ("Alpha Tint: Color", Vector) = (0,0,0,0)
		_AlphaTintPower ("Alpha Tint: Power", Float) = 1
		_AlphaTintMinAlpha ("Alpha Tint: Min Alpha", Range(0, 1)) = 0
		[Toggle(_ENABLEUVDISTORT_ON)] _EnableUVDistort ("Enable UV Distort", Float) = 0
		_UVDistortFade ("UV Distort: Fade", Range(0, 1)) = 1
		[NoScaleOffset] _UVDistortShaderMask ("UV Distort: Shader Mask", 2D) = "white" {}
		_UVDistortSpace ("UV Distort: Space", Float) = 0
		_UVDistortFrom ("UV Distort: From", Vector) = (0,0,0,0)
		_UVDistortTo ("UV Distort: To", Vector) = (0.1,0.1,0,0)
		_UVDistortSpeed ("UV Distort: Speed", Vector) = (2,2,0,0)
		_UVDistortNoiseScale ("UV Distort: Noise Scale", Vector) = (0.1,0.1,0,0)
		[HideInInspector] _texcoord ("", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	Category 
	{
		SubShader
		{
		LOD 0
			Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" "PreviewType"="Plane" }
			Blend SrcAlpha OneMinusSrcAlpha
			ColorMask RGB
			Cull Off
			Lighting Off 
			ZWrite Off
			ZTest LEqual
			Pass {
				CGPROGRAM
				#ifndef UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX
				#define UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(input)
				#endif
				#pragma vertex vert
				#pragma fragment frag
				#pragma target 2.0
				#pragma multi_compile_instancing
				#pragma multi_compile_particles
				#pragma multi_compile_fog
				#include "UnityShaderVariables.cginc"
				#include "UnityCG.cginc"
				struct appdata_t 
				{
					float4 vertex : POSITION;
					fixed4 color : COLOR;
					float4 texcoord : TEXCOORD0;
					UNITY_VERTEX_INPUT_INSTANCE_ID
					
				};
				struct v2f 
				{
					float4 vertex : SV_POSITION;
					fixed4 color : COLOR;
					float4 texcoord : TEXCOORD0;
					UNITY_FOG_COORDS(1)
					#ifdef SOFTPARTICLES_ON
					float4 projPos : TEXCOORD2;
					#endif
					UNITY_VERTEX_INPUT_INSTANCE_ID
					UNITY_VERTEX_OUTPUT_STEREO
					
				};
				#if UNITY_VERSION >= 560
				UNITY_DECLARE_DEPTH_TEXTURE( _CameraDepthTexture );
				#else
				uniform sampler2D_float _CameraDepthTexture;
				#endif
				uniform sampler2D _MainTex;
				uniform fixed4 _TintColor;
				uniform float4 _MainTex_ST;
				uniform float _InvFade;
				v2f vert ( appdata_t v  )
				{
					v2f o;
					UNITY_SETUP_INSTANCE_ID(v);
					UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
					UNITY_TRANSFER_INSTANCE_ID(v, o);
					

					v.vertex.xyz += _SinTime.xyz;
					o.vertex = UnityObjectToClipPos(v.vertex);
					#ifdef SOFTPARTICLES_ON
						o.projPos = ComputeScreenPos (o.vertex);
						COMPUTE_EYEDEPTH(o.projPos.z);
					#endif
					o.color = v.color;
					o.texcoord = v.texcoord;
					UNITY_TRANSFER_FOG(o,o.vertex);
					return o;
				}

				fixed4 frag ( v2f i  ) : SV_Target
				{
					UNITY_SETUP_INSTANCE_ID( i );
					UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX( i );

					#ifdef SOFTPARTICLES_ON
						float sceneZ = LinearEyeDepth (SAMPLE_DEPTH_TEXTURE_PROJ(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)));
						float partZ = i.projPos.z;
						float fade = saturate (_InvFade * (sceneZ-partZ));
						i.color.a *= fade;
					#endif

					

					fixed4 col = 2.0f * i.color * _TintColor * tex2D(_MainTex, i.texcoord.xy*_MainTex_ST.xy + _MainTex_ST.zw );
					UNITY_APPLY_FOG(i.fogCoord, col);
					return col;
				}
				ENDCG 
			}
		}	
	}

	//CustomEditor "CartoonCoffee.ParticleShaderGUI"
}