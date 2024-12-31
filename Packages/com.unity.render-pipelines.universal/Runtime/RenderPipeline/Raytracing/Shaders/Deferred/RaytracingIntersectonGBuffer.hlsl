#include "Packages/com.unity.render-pipelines.universal/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingIntersection.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/MaterialGBufferMacros.hlsl"
#include "Packages/com.unity.render-pipelines.universal/Runtime/Material/RaytracingMaterialGBufferMacros.hlsl"

// Structure that defines the current state of the intersection
struct RayIntersectionGBuffer
{
    float t;
    GBufferType0 gbuffer0;
    GBufferType1 gbuffer1;
    GBufferType2 gbuffer2;
    GBufferType3 gbuffer3;
};
