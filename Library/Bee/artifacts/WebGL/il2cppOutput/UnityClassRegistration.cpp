extern "C" void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_Input();
	RegisterModule_Input();

	void RegisterModule_InputLegacy();
	RegisterModule_InputLegacy();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_RuntimeInitializeOnLoadManagerInitializer();
	RegisterModule_RuntimeInitializeOnLoadManagerInitializer();

	void RegisterModule_SpriteMask();
	RegisterModule_SpriteMask();

	void RegisterModule_Subsystems();
	RegisterModule_Subsystems();

	void RegisterModule_Terrain();
	RegisterModule_Terrain();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_TextCoreFontEngine();
	RegisterModule_TextCoreFontEngine();

	void RegisterModule_TextCoreTextEngine();
	RegisterModule_TextCoreTextEngine();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UIElementsNative();
	RegisterModule_UIElementsNative();

	void RegisterModule_UIElements();
	RegisterModule_UIElements();

	void RegisterModule_VR();
	RegisterModule_VR();

	void RegisterModule_WebGL();
	RegisterModule_WebGL();

	void RegisterModule_XR();
	RegisterModule_XR();

}

template <typename T> void RegisterUnityClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

class Animator; template <> void RegisterUnityClass<Animator>(const char*);
class AnimatorController; template <> void RegisterUnityClass<AnimatorController>(const char*);
class AnimatorOverrideController; template <> void RegisterUnityClass<AnimatorOverrideController>(const char*);
class RuntimeAnimatorController; template <> void RegisterUnityClass<RuntimeAnimatorController>(const char*);
class AudioBehaviour; template <> void RegisterUnityClass<AudioBehaviour>(const char*);
class AudioClip; template <> void RegisterUnityClass<AudioClip>(const char*);
class AudioListener; template <> void RegisterUnityClass<AudioListener>(const char*);
class AudioManager; template <> void RegisterUnityClass<AudioManager>(const char*);
class AudioMixer; template <> void RegisterUnityClass<AudioMixer>(const char*);
class AudioMixerGroup; template <> void RegisterUnityClass<AudioMixerGroup>(const char*);
class AudioMixerSnapshot; template <> void RegisterUnityClass<AudioMixerSnapshot>(const char*);
class AudioReverbZone; template <> void RegisterUnityClass<AudioReverbZone>(const char*);
class AudioSource; template <> void RegisterUnityClass<AudioSource>(const char*);
class SampleClip; template <> void RegisterUnityClass<SampleClip>(const char*);
class Behaviour; template <> void RegisterUnityClass<Behaviour>(const char*);
class BillboardAsset; template <> void RegisterUnityClass<BillboardAsset>(const char*);
class BillboardRenderer; template <> void RegisterUnityClass<BillboardRenderer>(const char*);
class BuildSettings; template <> void RegisterUnityClass<BuildSettings>(const char*);
class Camera; template <> void RegisterUnityClass<Camera>(const char*);
namespace Unity { class Component; } template <> void RegisterUnityClass<Unity::Component>(const char*);
class ComputeShader; template <> void RegisterUnityClass<ComputeShader>(const char*);
class Cubemap; template <> void RegisterUnityClass<Cubemap>(const char*);
class CubemapArray; template <> void RegisterUnityClass<CubemapArray>(const char*);
class DelayedCallManager; template <> void RegisterUnityClass<DelayedCallManager>(const char*);
class EditorExtension; template <> void RegisterUnityClass<EditorExtension>(const char*);
class GameManager; template <> void RegisterUnityClass<GameManager>(const char*);
class GameObject; template <> void RegisterUnityClass<GameObject>(const char*);
class GlobalGameManager; template <> void RegisterUnityClass<GlobalGameManager>(const char*);
class GraphicsSettings; template <> void RegisterUnityClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterUnityClass<InputManager>(const char*);
class LevelGameManager; template <> void RegisterUnityClass<LevelGameManager>(const char*);
class Light; template <> void RegisterUnityClass<Light>(const char*);
class LightingSettings; template <> void RegisterUnityClass<LightingSettings>(const char*);
class LightmapSettings; template <> void RegisterUnityClass<LightmapSettings>(const char*);
class LightProbes; template <> void RegisterUnityClass<LightProbes>(const char*);
class LODGroup; template <> void RegisterUnityClass<LODGroup>(const char*);
class LowerResBlitTexture; template <> void RegisterUnityClass<LowerResBlitTexture>(const char*);
class Material; template <> void RegisterUnityClass<Material>(const char*);
class Mesh; template <> void RegisterUnityClass<Mesh>(const char*);
class MeshFilter; template <> void RegisterUnityClass<MeshFilter>(const char*);
class MeshRenderer; template <> void RegisterUnityClass<MeshRenderer>(const char*);
class MonoBehaviour; template <> void RegisterUnityClass<MonoBehaviour>(const char*);
class MonoManager; template <> void RegisterUnityClass<MonoManager>(const char*);
class MonoScript; template <> void RegisterUnityClass<MonoScript>(const char*);
class NamedObject; template <> void RegisterUnityClass<NamedObject>(const char*);
class Object; template <> void RegisterUnityClass<Object>(const char*);
class PlayerSettings; template <> void RegisterUnityClass<PlayerSettings>(const char*);
class PreloadData; template <> void RegisterUnityClass<PreloadData>(const char*);
class QualitySettings; template <> void RegisterUnityClass<QualitySettings>(const char*);
namespace UI { class RectTransform; } template <> void RegisterUnityClass<UI::RectTransform>(const char*);
class ReflectionProbe; template <> void RegisterUnityClass<ReflectionProbe>(const char*);
class Renderer; template <> void RegisterUnityClass<Renderer>(const char*);
class RenderSettings; template <> void RegisterUnityClass<RenderSettings>(const char*);
class RenderTexture; template <> void RegisterUnityClass<RenderTexture>(const char*);
class ResourceManager; template <> void RegisterUnityClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterUnityClass<RuntimeInitializeOnLoadManager>(const char*);
class Shader; template <> void RegisterUnityClass<Shader>(const char*);
class ShaderNameRegistry; template <> void RegisterUnityClass<ShaderNameRegistry>(const char*);
class SortingGroup; template <> void RegisterUnityClass<SortingGroup>(const char*);
class Sprite; template <> void RegisterUnityClass<Sprite>(const char*);
class SpriteAtlas; template <> void RegisterUnityClass<SpriteAtlas>(const char*);
class SpriteRenderer; template <> void RegisterUnityClass<SpriteRenderer>(const char*);
class TagManager; template <> void RegisterUnityClass<TagManager>(const char*);
class TextAsset; template <> void RegisterUnityClass<TextAsset>(const char*);
class Texture; template <> void RegisterUnityClass<Texture>(const char*);
class Texture2D; template <> void RegisterUnityClass<Texture2D>(const char*);
class Texture2DArray; template <> void RegisterUnityClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterUnityClass<Texture3D>(const char*);
class TimeManager; template <> void RegisterUnityClass<TimeManager>(const char*);
class Transform; template <> void RegisterUnityClass<Transform>(const char*);
class BoxCollider; template <> void RegisterUnityClass<BoxCollider>(const char*);
class CapsuleCollider; template <> void RegisterUnityClass<CapsuleCollider>(const char*);
class CharacterController; template <> void RegisterUnityClass<CharacterController>(const char*);
class Collider; template <> void RegisterUnityClass<Collider>(const char*);
class MeshCollider; template <> void RegisterUnityClass<MeshCollider>(const char*);
class PhysicsManager; template <> void RegisterUnityClass<PhysicsManager>(const char*);
class Rigidbody; template <> void RegisterUnityClass<Rigidbody>(const char*);
class SphereCollider; template <> void RegisterUnityClass<SphereCollider>(const char*);
class Collider2D; template <> void RegisterUnityClass<Collider2D>(const char*);
class Physics2DSettings; template <> void RegisterUnityClass<Physics2DSettings>(const char*);
class PolygonCollider2D; template <> void RegisterUnityClass<PolygonCollider2D>(const char*);
class SpriteMask; template <> void RegisterUnityClass<SpriteMask>(const char*);
class SpeedTreeWindAsset; template <> void RegisterUnityClass<SpeedTreeWindAsset>(const char*);
class Terrain; template <> void RegisterUnityClass<Terrain>(const char*);
class TerrainData; template <> void RegisterUnityClass<TerrainData>(const char*);
class Tree; template <> void RegisterUnityClass<Tree>(const char*);
namespace TextRendering { class Font; } template <> void RegisterUnityClass<TextRendering::Font>(const char*);
namespace UI { class Canvas; } template <> void RegisterUnityClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterUnityClass<UI::CanvasGroup>(const char*);
namespace UI { class CanvasRenderer; } template <> void RegisterUnityClass<UI::CanvasRenderer>(const char*);

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 90 non stripped classes
	//0. Animator
	RegisterUnityClass<Animator>("Animation");
	//1. AnimatorController
	RegisterUnityClass<AnimatorController>("Animation");
	//2. AnimatorOverrideController
	RegisterUnityClass<AnimatorOverrideController>("Animation");
	//3. RuntimeAnimatorController
	RegisterUnityClass<RuntimeAnimatorController>("Animation");
	//4. AudioBehaviour
	RegisterUnityClass<AudioBehaviour>("Audio");
	//5. AudioClip
	RegisterUnityClass<AudioClip>("Audio");
	//6. AudioListener
	RegisterUnityClass<AudioListener>("Audio");
	//7. AudioManager
	RegisterUnityClass<AudioManager>("Audio");
	//8. AudioMixer
	RegisterUnityClass<AudioMixer>("Audio");
	//9. AudioMixerGroup
	RegisterUnityClass<AudioMixerGroup>("Audio");
	//10. AudioMixerSnapshot
	RegisterUnityClass<AudioMixerSnapshot>("Audio");
	//11. AudioReverbZone
	RegisterUnityClass<AudioReverbZone>("Audio");
	//12. AudioSource
	RegisterUnityClass<AudioSource>("Audio");
	//13. SampleClip
	RegisterUnityClass<SampleClip>("Audio");
	//14. Behaviour
	RegisterUnityClass<Behaviour>("Core");
	//15. BillboardAsset
	RegisterUnityClass<BillboardAsset>("Core");
	//16. BillboardRenderer
	RegisterUnityClass<BillboardRenderer>("Core");
	//17. BuildSettings
	RegisterUnityClass<BuildSettings>("Core");
	//18. Camera
	RegisterUnityClass<Camera>("Core");
	//19. Component
	RegisterUnityClass<Unity::Component>("Core");
	//20. ComputeShader
	RegisterUnityClass<ComputeShader>("Core");
	//21. Cubemap
	RegisterUnityClass<Cubemap>("Core");
	//22. CubemapArray
	RegisterUnityClass<CubemapArray>("Core");
	//23. DelayedCallManager
	RegisterUnityClass<DelayedCallManager>("Core");
	//24. EditorExtension
	RegisterUnityClass<EditorExtension>("Core");
	//25. GameManager
	RegisterUnityClass<GameManager>("Core");
	//26. GameObject
	RegisterUnityClass<GameObject>("Core");
	//27. GlobalGameManager
	RegisterUnityClass<GlobalGameManager>("Core");
	//28. GraphicsSettings
	RegisterUnityClass<GraphicsSettings>("Core");
	//29. InputManager
	RegisterUnityClass<InputManager>("Core");
	//30. LevelGameManager
	RegisterUnityClass<LevelGameManager>("Core");
	//31. Light
	RegisterUnityClass<Light>("Core");
	//32. LightingSettings
	RegisterUnityClass<LightingSettings>("Core");
	//33. LightmapSettings
	RegisterUnityClass<LightmapSettings>("Core");
	//34. LightProbes
	RegisterUnityClass<LightProbes>("Core");
	//35. LODGroup
	RegisterUnityClass<LODGroup>("Core");
	//36. LowerResBlitTexture
	RegisterUnityClass<LowerResBlitTexture>("Core");
	//37. Material
	RegisterUnityClass<Material>("Core");
	//38. Mesh
	RegisterUnityClass<Mesh>("Core");
	//39. MeshFilter
	RegisterUnityClass<MeshFilter>("Core");
	//40. MeshRenderer
	RegisterUnityClass<MeshRenderer>("Core");
	//41. MonoBehaviour
	RegisterUnityClass<MonoBehaviour>("Core");
	//42. MonoManager
	RegisterUnityClass<MonoManager>("Core");
	//43. MonoScript
	RegisterUnityClass<MonoScript>("Core");
	//44. NamedObject
	RegisterUnityClass<NamedObject>("Core");
	//45. Object
	//Skipping Object
	//46. PlayerSettings
	RegisterUnityClass<PlayerSettings>("Core");
	//47. PreloadData
	RegisterUnityClass<PreloadData>("Core");
	//48. QualitySettings
	RegisterUnityClass<QualitySettings>("Core");
	//49. RectTransform
	RegisterUnityClass<UI::RectTransform>("Core");
	//50. ReflectionProbe
	RegisterUnityClass<ReflectionProbe>("Core");
	//51. Renderer
	RegisterUnityClass<Renderer>("Core");
	//52. RenderSettings
	RegisterUnityClass<RenderSettings>("Core");
	//53. RenderTexture
	RegisterUnityClass<RenderTexture>("Core");
	//54. ResourceManager
	RegisterUnityClass<ResourceManager>("Core");
	//55. RuntimeInitializeOnLoadManager
	RegisterUnityClass<RuntimeInitializeOnLoadManager>("Core");
	//56. Shader
	RegisterUnityClass<Shader>("Core");
	//57. ShaderNameRegistry
	RegisterUnityClass<ShaderNameRegistry>("Core");
	//58. SortingGroup
	RegisterUnityClass<SortingGroup>("Core");
	//59. Sprite
	RegisterUnityClass<Sprite>("Core");
	//60. SpriteAtlas
	RegisterUnityClass<SpriteAtlas>("Core");
	//61. SpriteRenderer
	RegisterUnityClass<SpriteRenderer>("Core");
	//62. TagManager
	RegisterUnityClass<TagManager>("Core");
	//63. TextAsset
	RegisterUnityClass<TextAsset>("Core");
	//64. Texture
	RegisterUnityClass<Texture>("Core");
	//65. Texture2D
	RegisterUnityClass<Texture2D>("Core");
	//66. Texture2DArray
	RegisterUnityClass<Texture2DArray>("Core");
	//67. Texture3D
	RegisterUnityClass<Texture3D>("Core");
	//68. TimeManager
	RegisterUnityClass<TimeManager>("Core");
	//69. Transform
	RegisterUnityClass<Transform>("Core");
	//70. BoxCollider
	RegisterUnityClass<BoxCollider>("Physics");
	//71. CapsuleCollider
	RegisterUnityClass<CapsuleCollider>("Physics");
	//72. CharacterController
	RegisterUnityClass<CharacterController>("Physics");
	//73. Collider
	RegisterUnityClass<Collider>("Physics");
	//74. MeshCollider
	RegisterUnityClass<MeshCollider>("Physics");
	//75. PhysicsManager
	RegisterUnityClass<PhysicsManager>("Physics");
	//76. Rigidbody
	RegisterUnityClass<Rigidbody>("Physics");
	//77. SphereCollider
	RegisterUnityClass<SphereCollider>("Physics");
	//78. Collider2D
	RegisterUnityClass<Collider2D>("Physics2D");
	//79. Physics2DSettings
	RegisterUnityClass<Physics2DSettings>("Physics2D");
	//80. PolygonCollider2D
	RegisterUnityClass<PolygonCollider2D>("Physics2D");
	//81. SpriteMask
	RegisterUnityClass<SpriteMask>("SpriteMask");
	//82. SpeedTreeWindAsset
	RegisterUnityClass<SpeedTreeWindAsset>("Terrain");
	//83. Terrain
	RegisterUnityClass<Terrain>("Terrain");
	//84. TerrainData
	RegisterUnityClass<TerrainData>("Terrain");
	//85. Tree
	RegisterUnityClass<Tree>("Terrain");
	//86. Font
	RegisterUnityClass<TextRendering::Font>("TextRendering");
	//87. Canvas
	RegisterUnityClass<UI::Canvas>("UI");
	//88. CanvasGroup
	RegisterUnityClass<UI::CanvasGroup>("UI");
	//89. CanvasRenderer
	RegisterUnityClass<UI::CanvasRenderer>("UI");

}
