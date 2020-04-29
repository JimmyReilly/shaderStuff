Shader "Jimmy/DotProduct"
{
    SubShader {
        CGPROGRAM
            #pragma surface surf Lambert

            struct Input {
                float3 vieweDir;
            };

            void surf (Input IN, inout SurfaceOutput o){
                half dotp = dot(IN.vieweDir, o.Normal);
                o.Albedo = float3(dotp, 1, 1);
            }
        ENDCG
    }
    Fallback "Diffuse"
}