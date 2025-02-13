using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using AltV.Net.Data;
using AltV.Net.Native;
using AltV.Net.Elements.Args;
using AltV.Net.Elements.Entities;

namespace AltV.Net.Native
{
    public unsafe interface ILibrary
    {
        public delegate* unmanaged[Cdecl]<nint, void> Blip_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint> Blip_AttachedTo { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Blip_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, void> Blip_Fade { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAlpha { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAsFriendly { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAsHighDetail { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAsMissionCreator { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAsShortRange { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetBright { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetCategory { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetCrewIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Blip_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, short> Blip_GetDisplay { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetFlashInterval { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetFlashTimer { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetFlashes { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetFlashesAlternate { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetFriendIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Blip_GetGxtName { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetHeadingIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Blip_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Blip_GetName { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetNumber { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetOutlineIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Blip_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetPriority { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetPulse { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Blip_GetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetRoute { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Blip_GetRouteColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Vector2*, void> Blip_GetScaleXY { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Blip_GetSecondaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetShowCone { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetShrinked { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetSprite { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetTickVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetType { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Blip_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_IsAttached { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_IsGlobal { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Blip_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAlpha { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAsFriendly { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAsHighDetail { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAsMissionCreator { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAsShortRange { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetBright { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetCategory { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetCrewIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Blip_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, short, void> Blip_SetDisplay { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetFlashInterval { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetFlashTimer { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetFlashes { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetFlashesAlternate { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetFriendIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Blip_SetGxtName { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetHeadingIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Blip_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Blip_SetName { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetNumber { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetOutlineIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Blip_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetPriority { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetPulse { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Blip_SetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetRoute { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Blip_SetRouteColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Vector2, void> Blip_SetScaleXY { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Blip_SetSecondaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetShowCone { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetShrinked { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetSprite { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetTickVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Checkpoint_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Checkpoint_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Checkpoint_GetCheckpointType { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Checkpoint_GetColShapeType { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Checkpoint_GetColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Checkpoint_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Checkpoint_GetHeight { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Checkpoint_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Checkpoint_GetNextPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Checkpoint_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Checkpoint_GetRadius { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Checkpoint_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Checkpoint_IsPlayerIn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Checkpoint_IsPlayersOnly { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Checkpoint_IsVehicleIn { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Checkpoint_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Checkpoint_SetCheckpointType { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Checkpoint_SetColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Checkpoint_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Checkpoint_SetHeight { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Checkpoint_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Checkpoint_SetNextPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Checkpoint_SetPlayersOnly { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Checkpoint_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Checkpoint_SetRadius { get; }
        public delegate* unmanaged[Cdecl]<nint, void> ColShape_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> ColShape_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> ColShape_GetColShapeType { get; }
        public delegate* unmanaged[Cdecl]<nint, int> ColShape_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> ColShape_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> ColShape_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> ColShape_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> ColShape_IsPlayerIn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> ColShape_IsPlayersOnly { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> ColShape_IsVehicleIn { get; }
        public delegate* unmanaged[Cdecl]<nint, void> ColShape_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> ColShape_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> ColShape_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> ColShape_SetPlayersOnly { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> ColShape_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueBlip { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, nint> Core_CreateMValueBool { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong, nint, nint> Core_CreateMValueByteArray { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueCheckpoint { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], nint[], ulong, nint> Core_CreateMValueDict { get; }
        public delegate* unmanaged[Cdecl]<nint, double, nint> Core_CreateMValueDouble { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueFunction { get; }
        public delegate* unmanaged[Cdecl]<nint, long, nint> Core_CreateMValueInt { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], ulong, nint> Core_CreateMValueList { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Core_CreateMValueNil { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValuePlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, nint> Core_CreateMValueRgba { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueString { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong, nint> Core_CreateMValueUInt { get; }
        public delegate* unmanaged[Cdecl]<nint, Vector2, nint> Core_CreateMValueVector2 { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, nint> Core_CreateMValueVector3 { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueVoiceChannel { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Core_GetBranch { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Core_GetVersion { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, ulong> Core_HashPassword { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Core_IsDebug { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Core_SetPassword { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Core_StopServer { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Event_Cancel { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Event_PlayerBeforeConnect_Cancel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Event_WasCancelled { get; }
        public delegate* unmanaged[Cdecl]<nint, void> FreeCharArray { get; }
        public delegate* unmanaged[Cdecl]<nint, void> FreeString { get; }
        public delegate* unmanaged[Cdecl]<UIntArray*, void> FreeUIntArray { get; }
        public delegate* unmanaged[Cdecl]<nint, MValueFunctionCallback, nint> Invoker_Create { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Invoker_Destroy { get; }
        public delegate* unmanaged[Cdecl]<nint, void> MValueConst_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint[], ulong, nint> MValueConst_CallFunction { get; }
        public delegate* unmanaged[Cdecl]<nint, void> MValueConst_Delete { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> MValueConst_GetBool { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong, nint, void> MValueConst_GetByteArray { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> MValueConst_GetByteArraySize { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], nint[], byte> MValueConst_GetDict { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> MValueConst_GetDictSize { get; }
        public delegate* unmanaged[Cdecl]<nint, double> MValueConst_GetDouble { get; }
        public delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint> MValueConst_GetEntity { get; }
        public delegate* unmanaged[Cdecl]<nint, long> MValueConst_GetInt { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], byte> MValueConst_GetList { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> MValueConst_GetListSize { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> MValueConst_GetRGBA { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, ulong*, byte> MValueConst_GetString { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> MValueConst_GetType { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> MValueConst_GetUInt { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> MValueConst_GetVector3 { get; }
        public delegate* unmanaged[Cdecl]<nint, void> MValueConst_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, void> Player_AddWeaponComponent { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void> Player_AttachToEntity_Player { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void> Player_AttachToEntity_Vehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_ClearBloodDamage { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_ClearProps { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Player_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Player_DeleteStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Player_DeleteSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_Despawn { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_Detach { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Player_GetAimPos { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetArmor { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Player_GetAuthToken { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, Cloth*, void> Player_GetClothes { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Player_GetCurrentWeapon { get; }
        public delegate* unmanaged[Cdecl]<nint, UIntArray*, void> Player_GetCurrentWeaponComponents { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetCurrentWeaponTintIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Player_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, DlcCloth*, void> Player_GetDlcClothes { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, DlcProp*, void> Player_GetDlcProps { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Player_GetEntityAimOffset { get; }
        public delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint> Player_GetEntityAimingAt { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetEyeColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float> Player_GetFaceFeatureScale { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetHairColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetHairHighlightColor { get; }
        public delegate* unmanaged[Cdecl]<nint, HeadBlendData*, void> Player_GetHeadBlendData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, Rgba*, void> Player_GetHeadBlendPaletteColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, HeadOverlay*, void> Player_GetHeadOverlay { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation*, void> Player_GetHeadRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Player_GetHwidExHash { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Player_GetHwidHash { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetID { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Player_GetIP { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetInvincible { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetMaxArmor { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetMaxHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Player_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Player_GetModel { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Player_GetMoveSpeed { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Player_GetName { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Player_GetNetworkOwner { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Player_GetPing { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Player_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, float*, float*, float*, int*, void> Player_GetPositionCoords { get; }
        public delegate* unmanaged[Cdecl]<nint, float*, float*, float*, float*, float*, float*, int*, void> Player_GetPositionCoords2 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, Prop*, void> Player_GetProps { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation*, void> Player_GetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetSeat { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Player_GetSocialID { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Player_GetStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetStreamed { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Player_GetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Player_GetVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Player_GetWeaponCount { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, byte> Player_GetWeaponTintIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, WeaponArray*, void> Player_GetWeapons { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, int, byte, void> Player_GiveWeapon { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_HasStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_HasSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, byte> Player_HasWeaponComponent { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsAiming { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsConnected { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsCrouching { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsDead { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_IsEntityInStreamingRange_Player { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_IsEntityInStreamingRange_Vehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsFlashlightActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsInRagdoll { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsInVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsJumping { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsReloading { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsShooting { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsStealthy { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsSuperJumpEnabled { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Player_Kick { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, uint, void> Player_PlayAmbientSpeech { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_RemoveAllWeapons { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Player_RemoveFaceFeature { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Player_RemoveHeadOverlay { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, byte> Player_RemoveWeapon { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, void> Player_RemoveWeaponComponent { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Player_SetArmor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, byte, void> Player_SetClothes { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Player_SetCurrentWeapon { get; }
        public delegate* unmanaged[Cdecl]<nint, int, int, int, int, int, int, void> Player_SetDateTime { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Player_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, byte, uint, void> Player_SetDlcClothes { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, uint, void> Player_SetDlcProps { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, byte> Player_SetEyeColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float, byte> Player_SetFaceFeature { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetHairColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetHairHighlightColor { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, uint, uint, uint, uint, float, float, float, void> Player_SetHeadBlendData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, byte> Player_SetHeadBlendPaletteColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, float, byte> Player_SetHeadOverlay { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, byte> Player_SetHeadOverlayColor { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Player_SetHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, void> Player_SetIntoVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetInvincible { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Player_SetMaxArmor { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Player_SetMaxHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Player_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Player_SetModel { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, void> Player_SetNetworkOwner { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Player_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, void> Player_SetProps { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation, void> Player_SetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Player_SetStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetStreamed { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Player_SetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, byte, void> Player_SetWeaponTintIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Player_SetWeather { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, uint, void> Player_Spawn { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Resource_GetCSharpImpl { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], int, void> Resource_GetDependants { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Resource_GetDependantsSize { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], int, void> Resource_GetDependencies { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Resource_GetDependenciesSize { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Resource_GetExport { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], nint[], void> Resource_GetExports { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Resource_GetExportsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Resource_GetImpl { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Resource_GetMain { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Resource_GetName { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Resource_GetPath { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Resource_GetType { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Resource_IsStarted { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, nint, void> Resource_SetExport { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint[], nint[], int, void> Resource_SetExports { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Resource_Start { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Resource_Stop { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, Position, nint> Server_CreateBlip { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, nint, nint> Server_CreateBlipAttachedPlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, nint, nint> Server_CreateBlipAttachedVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, Position, float, float, Rgba, nint> Server_CreateCheckpoint { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, float, nint> Server_CreateColShapeCircle { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, Position, nint> Server_CreateColShapeCube { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, float, float, nint> Server_CreateColShapeCylinder { get; }
        public delegate* unmanaged[Cdecl]<nint, float, float, Vector2[], int, nint> Server_CreateColShapePolygon { get; }
        public delegate* unmanaged[Cdecl]<nint, float, float, float, float, float, nint> Server_CreateColShapeRectangle { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, float, nint> Server_CreateColShapeSphere { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, Position, Rotation, ushort*, nint> Server_CreateVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float, nint> Server_CreateVoiceChannel { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DeleteSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyBlip { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyCheckpoint { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyColShape { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyVoiceChannel { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Server_FileExists { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint*, void> Server_FileRead { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, byte*, nint> Server_GetEntityById { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Server_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Server_GetNetTime { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Server_GetPlayerCount { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], ulong, void> Server_GetPlayers { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Server_GetResource { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Server_GetRootDirectory { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Server_GetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Server_GetVehicleCount { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], ulong, void> Server_GetVehicles { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Server_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Server_HasSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogColored { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogDebug { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogError { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogInfo { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogWarning { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_RestartResource { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Server_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Server_SetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_StartResource { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_StopResource { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, AltV.Net.Server.CommandCallback, byte> Server_SubscribeCommand { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, nint[], int, void> Server_TriggerClientEvent { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint[], int, void> Server_TriggerClientEventForAll { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], int, nint, nint[], int, void> Server_TriggerClientEventForSome { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint[], int, void> Server_TriggerServerEvent { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Vehicle_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void> Vehicle_AttachToEntity_Player { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void> Vehicle_AttachToEntity_Vehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_DeleteStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_DeleteSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Vehicle_Detach { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_DoesWheelHasTire { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetAppearanceDataBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float> Vehicle_GetArmoredWindowHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetArmoredWindowShootCount { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetAttached { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetAttachedTo { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetBodyAdditionalHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetBodyHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetBumperDamageLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetCustomTires { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetDamageDataBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetDashboardColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Vehicle_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetDirtLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetDoorState { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetDriver { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Vehicle_GetEngineHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetGameStateBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetHeadlightColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetHealthDataBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Vehicle_GetID { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetInteriorColor { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Vehicle_GetLightsMultiplier { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetLivery { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetLockState { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Vehicle_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetMod { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetModKit { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetModKitsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetModel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetModsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, byte*, byte*, byte*, byte*, void> Vehicle_GetNeonActive { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Vehicle_GetNeonColor { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetNetworkOwner { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetNumberplateIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetNumberplateText { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetPartBulletHoles { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetPartDamageLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetPearlColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Vehicle_GetPetrolTankHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Vehicle_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, float*, float*, float*, float*, float*, float*, int*, void> Vehicle_GetPositionCoords2 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetPrimaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Vehicle_GetPrimaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetRadioStationIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetRearWheelVariation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetRepairsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetRoofLivery { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetRoofState { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation*, void> Vehicle_GetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetScriptDataBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetSecondaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Vehicle_GetSecondaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetSpecialDarkness { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Vehicle_GetStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetStreamed { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Vehicle_GetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Vehicle_GetTireSmokeColor { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte> Vehicle_GetTrainCarriageConfigIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte> Vehicle_GetTrainConfigIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Vehicle_GetTrainCruiseSpeed { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetTrainDirection { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Vehicle_GetTrainDistanceFromEngine { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetTrainEngineId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetTrainForceDoorsOpen { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetTrainLinkedToBackwardId { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetTrainLinkedToForwardId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetTrainRenderDerailed { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte> Vehicle_GetTrainTrackId { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Vehicle_GetVelocity { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWheelColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float> Vehicle_GetWheelHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWheelType { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWheelVariation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWheelsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWindowTint { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_HasArmoredWindows { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Vehicle_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Vehicle_HasStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Vehicle_HasSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_HasTrainPassengerCarriages { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsDaylightOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsDestroyed { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsDriftMode { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsEngineOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsExtraOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsFlamethrowerActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsHandbrakeActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsLightDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsManualEngineControl { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsNeonActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsNightlightOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsPrimaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsSecondaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsSirenActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsSpecialLightDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsTireSmokeColorCustom { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsTrainCaboose { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsTrainEngine { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsTrainMissionTrain { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWheelBurst { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWheelDetached { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWheelOnFire { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWindowDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWindowOpened { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadAppearanceDataFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadDamageDataFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadGameStateFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadHealthDataFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadScriptDataFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Vehicle_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Vehicle_Repair { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float, void> Vehicle_SetArmoredWindowHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetArmoredWindowShootCount { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Vehicle_SetBodyAdditionalHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Vehicle_SetBodyHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetBumperDamageLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetCustomTires { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetDashboardColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Vehicle_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetDirtLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetDoorState { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetDriftMode { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Vehicle_SetEngineHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetEngineOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetHeadlightColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetInteriorColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetLightDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Vehicle_SetLightsMultiplier { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetLivery { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetLockState { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetManualEngineControl { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Vehicle_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, byte> Vehicle_SetMod { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_SetModKit { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, void> Vehicle_SetNeonActive { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Vehicle_SetNeonColor { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, void> Vehicle_SetNetworkOwner { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Vehicle_SetNumberplateIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_SetNumberplateText { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetPartBulletHoles { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetPartDamageLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetPearlColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Vehicle_SetPetrolTankHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Vehicle_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetPrimaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Vehicle_SetPrimaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Vehicle_SetRadioStationIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetRearWheels { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetRoofLivery { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetRoofState { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation, void> Vehicle_SetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, nint, byte> Vehicle_SetSearchLight_Player { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, nint, byte> Vehicle_SetSearchLight_Vehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetSecondaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Vehicle_SetSecondaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetSirenActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetSpecialDarkness { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetSpecialLightDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Vehicle_SetStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetStreamed { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Vehicle_SetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Vehicle_SetTireSmokeColor { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte, void> Vehicle_SetTrainCarriageConfigIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte, void> Vehicle_SetTrainConfigIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Vehicle_SetTrainCruiseSpeed { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainDirection { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Vehicle_SetTrainDistanceFromEngine { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_SetTrainEngineId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainForceDoorsOpen { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainHasPassengerCarriages { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainIsCaboose { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainIsEngine { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_SetTrainLinkedToBackwardId { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_SetTrainLinkedToForwardId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainMissionTrain { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainRenderDerailed { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte, void> Vehicle_SetTrainTrackId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheelBurst { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetWheelColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheelDetached { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetWheelFixed { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheelHasTire { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float, void> Vehicle_SetWheelHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheelOnFire { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheels { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWindowDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWindowOpened { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetWindowTint { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_ToggleExtra { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_AddPlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, void> VoiceChannel_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, float> VoiceChannel_GetMaxDistance { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> VoiceChannel_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> VoiceChannel_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> VoiceChannel_HasPlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> VoiceChannel_IsPlayerMuted { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> VoiceChannel_IsSpatial { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_MutePlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_RemovePlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, void> VoiceChannel_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> VoiceChannel_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_UnmutePlayer { get; }

    }

    public unsafe class Library : ILibrary
    {
        private const string DllName = "csharp-module";

        public delegate* unmanaged[Cdecl]<nint, void> Blip_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint> Blip_AttachedTo { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Blip_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, void> Blip_Fade { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAlpha { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAsFriendly { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAsHighDetail { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAsMissionCreator { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetAsShortRange { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetBright { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetCategory { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetCrewIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Blip_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, short> Blip_GetDisplay { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetFlashInterval { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetFlashTimer { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetFlashes { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetFlashesAlternate { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetFriendIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Blip_GetGxtName { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetHeadingIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Blip_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Blip_GetName { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetNumber { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetOutlineIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Blip_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetPriority { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetPulse { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Blip_GetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetRoute { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Blip_GetRouteColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Vector2*, void> Blip_GetScaleXY { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Blip_GetSecondaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetShowCone { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetShrinked { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Blip_GetSprite { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetTickVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_GetType { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Blip_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_IsAttached { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Blip_IsGlobal { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Blip_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAlpha { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAsFriendly { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAsHighDetail { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAsMissionCreator { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetAsShortRange { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetBright { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetCategory { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetCrewIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Blip_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, short, void> Blip_SetDisplay { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetFlashInterval { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetFlashTimer { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetFlashes { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetFlashesAlternate { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetFriendIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Blip_SetGxtName { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetHeadingIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Blip_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Blip_SetName { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetNumber { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetOutlineIndicatorVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Blip_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetPriority { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetPulse { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Blip_SetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetRoute { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Blip_SetRouteColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Vector2, void> Blip_SetScaleXY { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Blip_SetSecondaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetShowCone { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetShrinked { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Blip_SetSprite { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Blip_SetTickVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Checkpoint_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Checkpoint_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Checkpoint_GetCheckpointType { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Checkpoint_GetColShapeType { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Checkpoint_GetColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Checkpoint_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Checkpoint_GetHeight { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Checkpoint_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Checkpoint_GetNextPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Checkpoint_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Checkpoint_GetRadius { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Checkpoint_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Checkpoint_IsPlayerIn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Checkpoint_IsPlayersOnly { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Checkpoint_IsVehicleIn { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Checkpoint_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Checkpoint_SetCheckpointType { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Checkpoint_SetColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Checkpoint_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Checkpoint_SetHeight { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Checkpoint_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Checkpoint_SetNextPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Checkpoint_SetPlayersOnly { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Checkpoint_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Checkpoint_SetRadius { get; }
        public delegate* unmanaged[Cdecl]<nint, void> ColShape_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> ColShape_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> ColShape_GetColShapeType { get; }
        public delegate* unmanaged[Cdecl]<nint, int> ColShape_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> ColShape_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> ColShape_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> ColShape_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> ColShape_IsPlayerIn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> ColShape_IsPlayersOnly { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> ColShape_IsVehicleIn { get; }
        public delegate* unmanaged[Cdecl]<nint, void> ColShape_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> ColShape_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> ColShape_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> ColShape_SetPlayersOnly { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> ColShape_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueBlip { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, nint> Core_CreateMValueBool { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong, nint, nint> Core_CreateMValueByteArray { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueCheckpoint { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], nint[], ulong, nint> Core_CreateMValueDict { get; }
        public delegate* unmanaged[Cdecl]<nint, double, nint> Core_CreateMValueDouble { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueFunction { get; }
        public delegate* unmanaged[Cdecl]<nint, long, nint> Core_CreateMValueInt { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], ulong, nint> Core_CreateMValueList { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Core_CreateMValueNil { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValuePlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, nint> Core_CreateMValueRgba { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueString { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong, nint> Core_CreateMValueUInt { get; }
        public delegate* unmanaged[Cdecl]<nint, Vector2, nint> Core_CreateMValueVector2 { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, nint> Core_CreateMValueVector3 { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Core_CreateMValueVoiceChannel { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Core_GetBranch { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Core_GetVersion { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, ulong> Core_HashPassword { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Core_IsDebug { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Core_SetPassword { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Core_StopServer { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Event_Cancel { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Event_PlayerBeforeConnect_Cancel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Event_WasCancelled { get; }
        public delegate* unmanaged[Cdecl]<nint, void> FreeCharArray { get; }
        public delegate* unmanaged[Cdecl]<nint, void> FreeString { get; }
        public delegate* unmanaged[Cdecl]<UIntArray*, void> FreeUIntArray { get; }
        public delegate* unmanaged[Cdecl]<nint, MValueFunctionCallback, nint> Invoker_Create { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Invoker_Destroy { get; }
        public delegate* unmanaged[Cdecl]<nint, void> MValueConst_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint[], ulong, nint> MValueConst_CallFunction { get; }
        public delegate* unmanaged[Cdecl]<nint, void> MValueConst_Delete { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> MValueConst_GetBool { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong, nint, void> MValueConst_GetByteArray { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> MValueConst_GetByteArraySize { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], nint[], byte> MValueConst_GetDict { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> MValueConst_GetDictSize { get; }
        public delegate* unmanaged[Cdecl]<nint, double> MValueConst_GetDouble { get; }
        public delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint> MValueConst_GetEntity { get; }
        public delegate* unmanaged[Cdecl]<nint, long> MValueConst_GetInt { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], byte> MValueConst_GetList { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> MValueConst_GetListSize { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> MValueConst_GetRGBA { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, ulong*, byte> MValueConst_GetString { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> MValueConst_GetType { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> MValueConst_GetUInt { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> MValueConst_GetVector3 { get; }
        public delegate* unmanaged[Cdecl]<nint, void> MValueConst_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, void> Player_AddWeaponComponent { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void> Player_AttachToEntity_Player { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void> Player_AttachToEntity_Vehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_ClearBloodDamage { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_ClearProps { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Player_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Player_DeleteStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Player_DeleteSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_Despawn { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_Detach { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Player_GetAimPos { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetArmor { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Player_GetAuthToken { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, Cloth*, void> Player_GetClothes { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Player_GetCurrentWeapon { get; }
        public delegate* unmanaged[Cdecl]<nint, UIntArray*, void> Player_GetCurrentWeaponComponents { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetCurrentWeaponTintIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Player_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, DlcCloth*, void> Player_GetDlcClothes { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, DlcProp*, void> Player_GetDlcProps { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Player_GetEntityAimOffset { get; }
        public delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint> Player_GetEntityAimingAt { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetEyeColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float> Player_GetFaceFeatureScale { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetHairColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetHairHighlightColor { get; }
        public delegate* unmanaged[Cdecl]<nint, HeadBlendData*, void> Player_GetHeadBlendData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, Rgba*, void> Player_GetHeadBlendPaletteColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, HeadOverlay*, void> Player_GetHeadOverlay { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation*, void> Player_GetHeadRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Player_GetHwidExHash { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Player_GetHwidHash { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetID { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Player_GetIP { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetInvincible { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetMaxArmor { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Player_GetMaxHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Player_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Player_GetModel { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Player_GetMoveSpeed { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Player_GetName { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Player_GetNetworkOwner { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Player_GetPing { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Player_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, float*, float*, float*, int*, void> Player_GetPositionCoords { get; }
        public delegate* unmanaged[Cdecl]<nint, float*, float*, float*, float*, float*, float*, int*, void> Player_GetPositionCoords2 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, Prop*, void> Player_GetProps { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation*, void> Player_GetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetSeat { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Player_GetSocialID { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Player_GetStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetStreamed { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Player_GetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Player_GetVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_GetVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Player_GetWeaponCount { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, byte> Player_GetWeaponTintIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, WeaponArray*, void> Player_GetWeapons { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, int, byte, void> Player_GiveWeapon { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_HasStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_HasSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, byte> Player_HasWeaponComponent { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsAiming { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsConnected { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsCrouching { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsDead { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_IsEntityInStreamingRange_Player { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Player_IsEntityInStreamingRange_Vehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsFlashlightActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsInRagdoll { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsInVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsJumping { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsReloading { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsShooting { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsStealthy { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Player_IsSuperJumpEnabled { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Player_Kick { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, uint, void> Player_PlayAmbientSpeech { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_RemoveAllWeapons { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Player_RemoveFaceFeature { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Player_RemoveHeadOverlay { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Player_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, byte> Player_RemoveWeapon { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, void> Player_RemoveWeaponComponent { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Player_SetArmor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, byte, void> Player_SetClothes { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Player_SetCurrentWeapon { get; }
        public delegate* unmanaged[Cdecl]<nint, int, int, int, int, int, int, void> Player_SetDateTime { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Player_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, byte, uint, void> Player_SetDlcClothes { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, uint, void> Player_SetDlcProps { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, byte> Player_SetEyeColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float, byte> Player_SetFaceFeature { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetHairColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetHairHighlightColor { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, uint, uint, uint, uint, uint, float, float, float, void> Player_SetHeadBlendData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, byte> Player_SetHeadBlendPaletteColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, float, byte> Player_SetHeadOverlay { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, byte> Player_SetHeadOverlayColor { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Player_SetHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, void> Player_SetIntoVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetInvincible { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Player_SetMaxArmor { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, void> Player_SetMaxHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Player_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Player_SetModel { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, void> Player_SetNetworkOwner { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Player_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, void> Player_SetProps { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation, void> Player_SetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Player_SetStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetStreamed { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Player_SetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Player_SetVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, byte, void> Player_SetWeaponTintIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Player_SetWeather { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, uint, void> Player_Spawn { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Resource_GetCSharpImpl { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], int, void> Resource_GetDependants { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Resource_GetDependantsSize { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], int, void> Resource_GetDependencies { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Resource_GetDependenciesSize { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Resource_GetExport { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], nint[], void> Resource_GetExports { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Resource_GetExportsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Resource_GetImpl { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Resource_GetMain { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Resource_GetName { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Resource_GetPath { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Resource_GetType { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Resource_IsStarted { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, nint, void> Resource_SetExport { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint[], nint[], int, void> Resource_SetExports { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Resource_Start { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Resource_Stop { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, Position, nint> Server_CreateBlip { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, nint, nint> Server_CreateBlipAttachedPlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, nint, nint> Server_CreateBlipAttachedVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, Position, float, float, Rgba, nint> Server_CreateCheckpoint { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, float, nint> Server_CreateColShapeCircle { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, Position, nint> Server_CreateColShapeCube { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, float, float, nint> Server_CreateColShapeCylinder { get; }
        public delegate* unmanaged[Cdecl]<nint, float, float, Vector2[], int, nint> Server_CreateColShapePolygon { get; }
        public delegate* unmanaged[Cdecl]<nint, float, float, float, float, float, nint> Server_CreateColShapeRectangle { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, float, nint> Server_CreateColShapeSphere { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, Position, Rotation, ushort*, nint> Server_CreateVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float, nint> Server_CreateVoiceChannel { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DeleteSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyBlip { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyCheckpoint { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyColShape { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyVehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_DestroyVoiceChannel { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Server_FileExists { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint*, void> Server_FileRead { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort, byte*, nint> Server_GetEntityById { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Server_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Server_GetNetTime { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Server_GetPlayerCount { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], ulong, void> Server_GetPlayers { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Server_GetResource { get; }
        public delegate* unmanaged[Cdecl]<nint, nint*, void> Server_GetRootDirectory { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Server_GetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, ulong> Server_GetVehicleCount { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], ulong, void> Server_GetVehicles { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Server_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Server_HasSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogColored { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogDebug { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogError { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogInfo { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_LogWarning { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_RestartResource { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Server_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Server_SetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_StartResource { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Server_StopResource { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, AltV.Net.Server.CommandCallback, byte> Server_SubscribeCommand { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, nint[], int, void> Server_TriggerClientEvent { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint[], int, void> Server_TriggerClientEventForAll { get; }
        public delegate* unmanaged[Cdecl]<nint, nint[], int, nint, nint[], int, void> Server_TriggerClientEventForSome { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint[], int, void> Server_TriggerServerEvent { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Vehicle_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void> Vehicle_AttachToEntity_Player { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void> Vehicle_AttachToEntity_Vehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_DeleteStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_DeleteSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Vehicle_Detach { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_DoesWheelHasTire { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetAppearanceDataBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float> Vehicle_GetArmoredWindowHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetArmoredWindowShootCount { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetAttached { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetAttachedTo { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetBodyAdditionalHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetBodyHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetBumperDamageLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetCustomTires { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetDamageDataBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetDashboardColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Vehicle_GetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetDirtLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetDoorState { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetDriver { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Vehicle_GetEngineHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetGameStateBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetHeadlightColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetHealthDataBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, ushort> Vehicle_GetID { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetInteriorColor { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Vehicle_GetLightsMultiplier { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetLivery { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetLockState { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Vehicle_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetMod { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetModKit { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetModKitsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetModel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetModsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, byte*, byte*, byte*, byte*, void> Vehicle_GetNeonActive { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Vehicle_GetNeonColor { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetNetworkOwner { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetNumberplateIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetNumberplateText { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetPartBulletHoles { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_GetPartDamageLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetPearlColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int> Vehicle_GetPetrolTankHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Vehicle_GetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, float*, float*, float*, float*, float*, float*, int*, void> Vehicle_GetPositionCoords2 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetPrimaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Vehicle_GetPrimaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, uint> Vehicle_GetRadioStationIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetRearWheelVariation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetRepairsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetRoofLivery { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetRoofState { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation*, void> Vehicle_GetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, int*, nint> Vehicle_GetScriptDataBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetSecondaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Vehicle_GetSecondaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetSpecialDarkness { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Vehicle_GetStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetStreamed { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> Vehicle_GetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba*, void> Vehicle_GetTireSmokeColor { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte> Vehicle_GetTrainCarriageConfigIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte> Vehicle_GetTrainConfigIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Vehicle_GetTrainCruiseSpeed { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetTrainDirection { get; }
        public delegate* unmanaged[Cdecl]<nint, float> Vehicle_GetTrainDistanceFromEngine { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetTrainEngineId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetTrainForceDoorsOpen { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetTrainLinkedToBackwardId { get; }
        public delegate* unmanaged[Cdecl]<nint, nint> Vehicle_GetTrainLinkedToForwardId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetTrainRenderDerailed { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte> Vehicle_GetTrainTrackId { get; }
        public delegate* unmanaged[Cdecl]<nint, Position*, void> Vehicle_GetVelocity { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWheelColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float> Vehicle_GetWheelHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWheelType { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWheelVariation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWheelsCount { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_GetWindowTint { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_HasArmoredWindows { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Vehicle_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Vehicle_HasStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> Vehicle_HasSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_HasTrainPassengerCarriages { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsDaylightOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsDestroyed { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsDriftMode { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsEngineOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsExtraOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsFlamethrowerActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsHandbrakeActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsLightDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsManualEngineControl { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsNeonActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsNightlightOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsPrimaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsSecondaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsSirenActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsSpecialLightDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsTireSmokeColorCustom { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsTrainCaboose { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsTrainEngine { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> Vehicle_IsTrainMissionTrain { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWheelBurst { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWheelDetached { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWheelOnFire { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWindowDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_IsWindowOpened { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadAppearanceDataFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadDamageDataFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadGameStateFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadHealthDataFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, string, void> Vehicle_LoadScriptDataFromBase64 { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Vehicle_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, void> Vehicle_Repair { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float, void> Vehicle_SetArmoredWindowHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetArmoredWindowShootCount { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Vehicle_SetBodyAdditionalHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Vehicle_SetBodyHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetBumperDamageLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetCustomTires { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetDashboardColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Vehicle_SetDimension { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetDirtLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetDoorState { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetDriftMode { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Vehicle_SetEngineHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetEngineOn { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetHeadlightColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetInteriorColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetLightDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Vehicle_SetLightsMultiplier { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetLivery { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetLockState { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetManualEngineControl { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Vehicle_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, byte> Vehicle_SetMod { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte> Vehicle_SetModKit { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, void> Vehicle_SetNeonActive { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Vehicle_SetNeonColor { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte, void> Vehicle_SetNetworkOwner { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Vehicle_SetNumberplateIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_SetNumberplateText { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetPartBulletHoles { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetPartDamageLevel { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetPearlColor { get; }
        public delegate* unmanaged[Cdecl]<nint, int, void> Vehicle_SetPetrolTankHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, Position, void> Vehicle_SetPosition { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetPrimaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Vehicle_SetPrimaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, uint, void> Vehicle_SetRadioStationIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetRearWheels { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetRoofLivery { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetRoofState { get; }
        public delegate* unmanaged[Cdecl]<nint, Rotation, void> Vehicle_SetRotation { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, nint, byte> Vehicle_SetSearchLight_Player { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, nint, byte> Vehicle_SetSearchLight_Vehicle { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetSecondaryColor { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Vehicle_SetSecondaryColorRGB { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetSirenActive { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetSpecialDarkness { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetSpecialLightDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Vehicle_SetStreamSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetStreamed { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> Vehicle_SetSyncedMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, Rgba, void> Vehicle_SetTireSmokeColor { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte, void> Vehicle_SetTrainCarriageConfigIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte, void> Vehicle_SetTrainConfigIndex { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Vehicle_SetTrainCruiseSpeed { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainDirection { get; }
        public delegate* unmanaged[Cdecl]<nint, float, void> Vehicle_SetTrainDistanceFromEngine { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_SetTrainEngineId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainForceDoorsOpen { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainHasPassengerCarriages { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainIsCaboose { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainIsEngine { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_SetTrainLinkedToBackwardId { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> Vehicle_SetTrainLinkedToForwardId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainMissionTrain { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetTrainRenderDerailed { get; }
        public delegate* unmanaged[Cdecl]<nint, sbyte, void> Vehicle_SetTrainTrackId { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetVisible { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheelBurst { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetWheelColor { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheelDetached { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetWheelFixed { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheelHasTire { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, float, void> Vehicle_SetWheelHealth { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheelOnFire { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWheels { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWindowDamaged { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_SetWindowOpened { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, void> Vehicle_SetWindowTint { get; }
        public delegate* unmanaged[Cdecl]<nint, byte, byte, void> Vehicle_ToggleExtra { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_AddPlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, void> VoiceChannel_AddRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_DeleteMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, float> VoiceChannel_GetMaxDistance { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint> VoiceChannel_GetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> VoiceChannel_HasMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> VoiceChannel_HasPlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, byte> VoiceChannel_IsPlayerMuted { get; }
        public delegate* unmanaged[Cdecl]<nint, byte> VoiceChannel_IsSpatial { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_MutePlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_RemovePlayer { get; }
        public delegate* unmanaged[Cdecl]<nint, void> VoiceChannel_RemoveRef { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, nint, void> VoiceChannel_SetMetaData { get; }
        public delegate* unmanaged[Cdecl]<nint, nint, void> VoiceChannel_UnmutePlayer { get; }

        public Library() 
        {
            const DllImportSearchPath dllImportSearchPath = DllImportSearchPath.LegacyBehavior
                                                            | DllImportSearchPath.AssemblyDirectory
                                                            | DllImportSearchPath.SafeDirectories
                                                            | DllImportSearchPath.System32
                                                            | DllImportSearchPath.UserDirectories
                                                            | DllImportSearchPath.ApplicationDirectory
                                                            | DllImportSearchPath.UseDllDirectoryForDependencies;
            var handle = NativeLibrary.Load(DllName, Assembly.GetExecutingAssembly(), dllImportSearchPath);
            Blip_AddRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Blip_AddRef");
            Blip_AttachedTo = (delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint>) NativeLibrary.GetExport(handle, "Blip_AttachedTo");
            Blip_DeleteMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Blip_DeleteMetaData");
            Blip_Fade = (delegate* unmanaged[Cdecl]<nint, uint, uint, void>) NativeLibrary.GetExport(handle, "Blip_Fade");
            Blip_GetAlpha = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetAlpha");
            Blip_GetAsFriendly = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetAsFriendly");
            Blip_GetAsHighDetail = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetAsHighDetail");
            Blip_GetAsMissionCreator = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetAsMissionCreator");
            Blip_GetAsShortRange = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetAsShortRange");
            Blip_GetBright = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetBright");
            Blip_GetCategory = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Blip_GetCategory");
            Blip_GetColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetColor");
            Blip_GetCrewIndicatorVisible = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetCrewIndicatorVisible");
            Blip_GetDimension = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Blip_GetDimension");
            Blip_GetDisplay = (delegate* unmanaged[Cdecl]<nint, short>) NativeLibrary.GetExport(handle, "Blip_GetDisplay");
            Blip_GetFlashInterval = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Blip_GetFlashInterval");
            Blip_GetFlashTimer = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Blip_GetFlashTimer");
            Blip_GetFlashes = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetFlashes");
            Blip_GetFlashesAlternate = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetFlashesAlternate");
            Blip_GetFriendIndicatorVisible = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetFriendIndicatorVisible");
            Blip_GetGxtName = (delegate* unmanaged[Cdecl]<nint, nint*, void>) NativeLibrary.GetExport(handle, "Blip_GetGxtName");
            Blip_GetHeadingIndicatorVisible = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetHeadingIndicatorVisible");
            Blip_GetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Blip_GetMetaData");
            Blip_GetName = (delegate* unmanaged[Cdecl]<nint, nint*, void>) NativeLibrary.GetExport(handle, "Blip_GetName");
            Blip_GetNumber = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Blip_GetNumber");
            Blip_GetOutlineIndicatorVisible = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetOutlineIndicatorVisible");
            Blip_GetPosition = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "Blip_GetPosition");
            Blip_GetPriority = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Blip_GetPriority");
            Blip_GetPulse = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetPulse");
            Blip_GetRotation = (delegate* unmanaged[Cdecl]<nint, float>) NativeLibrary.GetExport(handle, "Blip_GetRotation");
            Blip_GetRoute = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetRoute");
            Blip_GetRouteColor = (delegate* unmanaged[Cdecl]<nint, Rgba*, void>) NativeLibrary.GetExport(handle, "Blip_GetRouteColor");
            Blip_GetScaleXY = (delegate* unmanaged[Cdecl]<nint, Vector2*, void>) NativeLibrary.GetExport(handle, "Blip_GetScaleXY");
            Blip_GetSecondaryColor = (delegate* unmanaged[Cdecl]<nint, Rgba*, void>) NativeLibrary.GetExport(handle, "Blip_GetSecondaryColor");
            Blip_GetShowCone = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetShowCone");
            Blip_GetShrinked = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetShrinked");
            Blip_GetSprite = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Blip_GetSprite");
            Blip_GetTickVisible = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetTickVisible");
            Blip_GetType = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_GetType");
            Blip_HasMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Blip_HasMetaData");
            Blip_IsAttached = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_IsAttached");
            Blip_IsGlobal = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Blip_IsGlobal");
            Blip_RemoveRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Blip_RemoveRef");
            Blip_SetAlpha = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetAlpha");
            Blip_SetAsFriendly = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetAsFriendly");
            Blip_SetAsHighDetail = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetAsHighDetail");
            Blip_SetAsMissionCreator = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetAsMissionCreator");
            Blip_SetAsShortRange = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetAsShortRange");
            Blip_SetBright = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetBright");
            Blip_SetCategory = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Blip_SetCategory");
            Blip_SetColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetColor");
            Blip_SetCrewIndicatorVisible = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetCrewIndicatorVisible");
            Blip_SetDimension = (delegate* unmanaged[Cdecl]<nint, int, void>) NativeLibrary.GetExport(handle, "Blip_SetDimension");
            Blip_SetDisplay = (delegate* unmanaged[Cdecl]<nint, short, void>) NativeLibrary.GetExport(handle, "Blip_SetDisplay");
            Blip_SetFlashInterval = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Blip_SetFlashInterval");
            Blip_SetFlashTimer = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Blip_SetFlashTimer");
            Blip_SetFlashes = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetFlashes");
            Blip_SetFlashesAlternate = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetFlashesAlternate");
            Blip_SetFriendIndicatorVisible = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetFriendIndicatorVisible");
            Blip_SetGxtName = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Blip_SetGxtName");
            Blip_SetHeadingIndicatorVisible = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetHeadingIndicatorVisible");
            Blip_SetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Blip_SetMetaData");
            Blip_SetName = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Blip_SetName");
            Blip_SetNumber = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Blip_SetNumber");
            Blip_SetOutlineIndicatorVisible = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetOutlineIndicatorVisible");
            Blip_SetPosition = (delegate* unmanaged[Cdecl]<nint, Position, void>) NativeLibrary.GetExport(handle, "Blip_SetPosition");
            Blip_SetPriority = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Blip_SetPriority");
            Blip_SetPulse = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetPulse");
            Blip_SetRotation = (delegate* unmanaged[Cdecl]<nint, float, void>) NativeLibrary.GetExport(handle, "Blip_SetRotation");
            Blip_SetRoute = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetRoute");
            Blip_SetRouteColor = (delegate* unmanaged[Cdecl]<nint, Rgba, void>) NativeLibrary.GetExport(handle, "Blip_SetRouteColor");
            Blip_SetScaleXY = (delegate* unmanaged[Cdecl]<nint, Vector2, void>) NativeLibrary.GetExport(handle, "Blip_SetScaleXY");
            Blip_SetSecondaryColor = (delegate* unmanaged[Cdecl]<nint, Rgba, void>) NativeLibrary.GetExport(handle, "Blip_SetSecondaryColor");
            Blip_SetShowCone = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetShowCone");
            Blip_SetShrinked = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetShrinked");
            Blip_SetSprite = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Blip_SetSprite");
            Blip_SetTickVisible = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Blip_SetTickVisible");
            Checkpoint_AddRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Checkpoint_AddRef");
            Checkpoint_DeleteMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Checkpoint_DeleteMetaData");
            Checkpoint_GetCheckpointType = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Checkpoint_GetCheckpointType");
            Checkpoint_GetColShapeType = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Checkpoint_GetColShapeType");
            Checkpoint_GetColor = (delegate* unmanaged[Cdecl]<nint, Rgba*, void>) NativeLibrary.GetExport(handle, "Checkpoint_GetColor");
            Checkpoint_GetDimension = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Checkpoint_GetDimension");
            Checkpoint_GetHeight = (delegate* unmanaged[Cdecl]<nint, float>) NativeLibrary.GetExport(handle, "Checkpoint_GetHeight");
            Checkpoint_GetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Checkpoint_GetMetaData");
            Checkpoint_GetNextPosition = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "Checkpoint_GetNextPosition");
            Checkpoint_GetPosition = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "Checkpoint_GetPosition");
            Checkpoint_GetRadius = (delegate* unmanaged[Cdecl]<nint, float>) NativeLibrary.GetExport(handle, "Checkpoint_GetRadius");
            Checkpoint_HasMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Checkpoint_HasMetaData");
            Checkpoint_IsPlayerIn = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Checkpoint_IsPlayerIn");
            Checkpoint_IsPlayersOnly = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Checkpoint_IsPlayersOnly");
            Checkpoint_IsVehicleIn = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Checkpoint_IsVehicleIn");
            Checkpoint_RemoveRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Checkpoint_RemoveRef");
            Checkpoint_SetCheckpointType = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetCheckpointType");
            Checkpoint_SetColor = (delegate* unmanaged[Cdecl]<nint, Rgba, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetColor");
            Checkpoint_SetDimension = (delegate* unmanaged[Cdecl]<nint, int, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetDimension");
            Checkpoint_SetHeight = (delegate* unmanaged[Cdecl]<nint, float, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetHeight");
            Checkpoint_SetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetMetaData");
            Checkpoint_SetNextPosition = (delegate* unmanaged[Cdecl]<nint, Position, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetNextPosition");
            Checkpoint_SetPlayersOnly = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetPlayersOnly");
            Checkpoint_SetPosition = (delegate* unmanaged[Cdecl]<nint, Position, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetPosition");
            Checkpoint_SetRadius = (delegate* unmanaged[Cdecl]<nint, float, void>) NativeLibrary.GetExport(handle, "Checkpoint_SetRadius");
            ColShape_AddRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "ColShape_AddRef");
            ColShape_DeleteMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "ColShape_DeleteMetaData");
            ColShape_GetColShapeType = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "ColShape_GetColShapeType");
            ColShape_GetDimension = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "ColShape_GetDimension");
            ColShape_GetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "ColShape_GetMetaData");
            ColShape_GetPosition = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "ColShape_GetPosition");
            ColShape_HasMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "ColShape_HasMetaData");
            ColShape_IsPlayerIn = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "ColShape_IsPlayerIn");
            ColShape_IsPlayersOnly = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "ColShape_IsPlayersOnly");
            ColShape_IsVehicleIn = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "ColShape_IsVehicleIn");
            ColShape_RemoveRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "ColShape_RemoveRef");
            ColShape_SetDimension = (delegate* unmanaged[Cdecl]<nint, int, void>) NativeLibrary.GetExport(handle, "ColShape_SetDimension");
            ColShape_SetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "ColShape_SetMetaData");
            ColShape_SetPlayersOnly = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "ColShape_SetPlayersOnly");
            ColShape_SetPosition = (delegate* unmanaged[Cdecl]<nint, Position, void>) NativeLibrary.GetExport(handle, "ColShape_SetPosition");
            Core_CreateMValueBlip = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueBlip");
            Core_CreateMValueBool = (delegate* unmanaged[Cdecl]<nint, byte, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueBool");
            Core_CreateMValueByteArray = (delegate* unmanaged[Cdecl]<nint, ulong, nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueByteArray");
            Core_CreateMValueCheckpoint = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueCheckpoint");
            Core_CreateMValueDict = (delegate* unmanaged[Cdecl]<nint, nint[], nint[], ulong, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueDict");
            Core_CreateMValueDouble = (delegate* unmanaged[Cdecl]<nint, double, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueDouble");
            Core_CreateMValueFunction = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueFunction");
            Core_CreateMValueInt = (delegate* unmanaged[Cdecl]<nint, long, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueInt");
            Core_CreateMValueList = (delegate* unmanaged[Cdecl]<nint, nint[], ulong, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueList");
            Core_CreateMValueNil = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueNil");
            Core_CreateMValuePlayer = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValuePlayer");
            Core_CreateMValueRgba = (delegate* unmanaged[Cdecl]<nint, Rgba, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueRgba");
            Core_CreateMValueString = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueString");
            Core_CreateMValueUInt = (delegate* unmanaged[Cdecl]<nint, ulong, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueUInt");
            Core_CreateMValueVector2 = (delegate* unmanaged[Cdecl]<nint, Vector2, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueVector2");
            Core_CreateMValueVector3 = (delegate* unmanaged[Cdecl]<nint, Position, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueVector3");
            Core_CreateMValueVehicle = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueVehicle");
            Core_CreateMValueVoiceChannel = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Core_CreateMValueVoiceChannel");
            Core_GetBranch = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Core_GetBranch");
            Core_GetVersion = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Core_GetVersion");
            Core_HashPassword = (delegate* unmanaged[Cdecl]<nint, nint, ulong>) NativeLibrary.GetExport(handle, "Core_HashPassword");
            Core_IsDebug = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Core_IsDebug");
            Core_SetPassword = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Core_SetPassword");
            Core_StopServer = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Core_StopServer");
            Event_Cancel = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Event_Cancel");
            Event_PlayerBeforeConnect_Cancel = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Event_PlayerBeforeConnect_Cancel");
            Event_WasCancelled = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Event_WasCancelled");
            FreeCharArray = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "FreeCharArray");
            FreeString = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "FreeString");
            FreeUIntArray = (delegate* unmanaged[Cdecl]<UIntArray*, void>) NativeLibrary.GetExport(handle, "FreeUIntArray");
            Invoker_Create = (delegate* unmanaged[Cdecl]<nint, MValueFunctionCallback, nint>) NativeLibrary.GetExport(handle, "Invoker_Create");
            Invoker_Destroy = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Invoker_Destroy");
            MValueConst_AddRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "MValueConst_AddRef");
            MValueConst_CallFunction = (delegate* unmanaged[Cdecl]<nint, nint, nint[], ulong, nint>) NativeLibrary.GetExport(handle, "MValueConst_CallFunction");
            MValueConst_Delete = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "MValueConst_Delete");
            MValueConst_GetBool = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "MValueConst_GetBool");
            MValueConst_GetByteArray = (delegate* unmanaged[Cdecl]<nint, ulong, nint, void>) NativeLibrary.GetExport(handle, "MValueConst_GetByteArray");
            MValueConst_GetByteArraySize = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "MValueConst_GetByteArraySize");
            MValueConst_GetDict = (delegate* unmanaged[Cdecl]<nint, nint[], nint[], byte>) NativeLibrary.GetExport(handle, "MValueConst_GetDict");
            MValueConst_GetDictSize = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "MValueConst_GetDictSize");
            MValueConst_GetDouble = (delegate* unmanaged[Cdecl]<nint, double>) NativeLibrary.GetExport(handle, "MValueConst_GetDouble");
            MValueConst_GetEntity = (delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint>) NativeLibrary.GetExport(handle, "MValueConst_GetEntity");
            MValueConst_GetInt = (delegate* unmanaged[Cdecl]<nint, long>) NativeLibrary.GetExport(handle, "MValueConst_GetInt");
            MValueConst_GetList = (delegate* unmanaged[Cdecl]<nint, nint[], byte>) NativeLibrary.GetExport(handle, "MValueConst_GetList");
            MValueConst_GetListSize = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "MValueConst_GetListSize");
            MValueConst_GetRGBA = (delegate* unmanaged[Cdecl]<nint, Rgba*, void>) NativeLibrary.GetExport(handle, "MValueConst_GetRGBA");
            MValueConst_GetString = (delegate* unmanaged[Cdecl]<nint, nint*, ulong*, byte>) NativeLibrary.GetExport(handle, "MValueConst_GetString");
            MValueConst_GetType = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "MValueConst_GetType");
            MValueConst_GetUInt = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "MValueConst_GetUInt");
            MValueConst_GetVector3 = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "MValueConst_GetVector3");
            MValueConst_RemoveRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "MValueConst_RemoveRef");
            Player_AddRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Player_AddRef");
            Player_AddWeaponComponent = (delegate* unmanaged[Cdecl]<nint, uint, uint, void>) NativeLibrary.GetExport(handle, "Player_AddWeaponComponent");
            Player_AttachToEntity_Player = (delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void>) NativeLibrary.GetExport(handle, "Player_AttachToEntity_Player");
            Player_AttachToEntity_Vehicle = (delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void>) NativeLibrary.GetExport(handle, "Player_AttachToEntity_Vehicle");
            Player_ClearBloodDamage = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Player_ClearBloodDamage");
            Player_ClearProps = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Player_ClearProps");
            Player_DeleteMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Player_DeleteMetaData");
            Player_DeleteStreamSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Player_DeleteStreamSyncedMetaData");
            Player_DeleteSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Player_DeleteSyncedMetaData");
            Player_Despawn = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Player_Despawn");
            Player_Detach = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Player_Detach");
            Player_GetAimPos = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "Player_GetAimPos");
            Player_GetArmor = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Player_GetArmor");
            Player_GetAuthToken = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Player_GetAuthToken");
            Player_GetClothes = (delegate* unmanaged[Cdecl]<nint, byte, Cloth*, void>) NativeLibrary.GetExport(handle, "Player_GetClothes");
            Player_GetCurrentWeapon = (delegate* unmanaged[Cdecl]<nint, uint>) NativeLibrary.GetExport(handle, "Player_GetCurrentWeapon");
            Player_GetCurrentWeaponComponents = (delegate* unmanaged[Cdecl]<nint, UIntArray*, void>) NativeLibrary.GetExport(handle, "Player_GetCurrentWeaponComponents");
            Player_GetCurrentWeaponTintIndex = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_GetCurrentWeaponTintIndex");
            Player_GetDimension = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Player_GetDimension");
            Player_GetDlcClothes = (delegate* unmanaged[Cdecl]<nint, byte, DlcCloth*, void>) NativeLibrary.GetExport(handle, "Player_GetDlcClothes");
            Player_GetDlcProps = (delegate* unmanaged[Cdecl]<nint, byte, DlcProp*, void>) NativeLibrary.GetExport(handle, "Player_GetDlcProps");
            Player_GetEntityAimOffset = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "Player_GetEntityAimOffset");
            Player_GetEntityAimingAt = (delegate* unmanaged[Cdecl]<nint, BaseObjectType*, nint>) NativeLibrary.GetExport(handle, "Player_GetEntityAimingAt");
            Player_GetEyeColor = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Player_GetEyeColor");
            Player_GetFaceFeatureScale = (delegate* unmanaged[Cdecl]<nint, byte, float>) NativeLibrary.GetExport(handle, "Player_GetFaceFeatureScale");
            Player_GetHairColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_GetHairColor");
            Player_GetHairHighlightColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_GetHairHighlightColor");
            Player_GetHeadBlendData = (delegate* unmanaged[Cdecl]<nint, HeadBlendData*, void>) NativeLibrary.GetExport(handle, "Player_GetHeadBlendData");
            Player_GetHeadBlendPaletteColor = (delegate* unmanaged[Cdecl]<nint, byte, Rgba*, void>) NativeLibrary.GetExport(handle, "Player_GetHeadBlendPaletteColor");
            Player_GetHeadOverlay = (delegate* unmanaged[Cdecl]<nint, byte, HeadOverlay*, void>) NativeLibrary.GetExport(handle, "Player_GetHeadOverlay");
            Player_GetHeadRotation = (delegate* unmanaged[Cdecl]<nint, Rotation*, void>) NativeLibrary.GetExport(handle, "Player_GetHeadRotation");
            Player_GetHealth = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Player_GetHealth");
            Player_GetHwidExHash = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "Player_GetHwidExHash");
            Player_GetHwidHash = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "Player_GetHwidHash");
            Player_GetID = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Player_GetID");
            Player_GetIP = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Player_GetIP");
            Player_GetInvincible = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_GetInvincible");
            Player_GetMaxArmor = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Player_GetMaxArmor");
            Player_GetMaxHealth = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Player_GetMaxHealth");
            Player_GetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Player_GetMetaData");
            Player_GetModel = (delegate* unmanaged[Cdecl]<nint, uint>) NativeLibrary.GetExport(handle, "Player_GetModel");
            Player_GetMoveSpeed = (delegate* unmanaged[Cdecl]<nint, float>) NativeLibrary.GetExport(handle, "Player_GetMoveSpeed");
            Player_GetName = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Player_GetName");
            Player_GetNetworkOwner = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Player_GetNetworkOwner");
            Player_GetPing = (delegate* unmanaged[Cdecl]<nint, uint>) NativeLibrary.GetExport(handle, "Player_GetPing");
            Player_GetPosition = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "Player_GetPosition");
            Player_GetPositionCoords = (delegate* unmanaged[Cdecl]<nint, float*, float*, float*, int*, void>) NativeLibrary.GetExport(handle, "Player_GetPositionCoords");
            Player_GetPositionCoords2 = (delegate* unmanaged[Cdecl]<nint, float*, float*, float*, float*, float*, float*, int*, void>) NativeLibrary.GetExport(handle, "Player_GetPositionCoords2");
            Player_GetProps = (delegate* unmanaged[Cdecl]<nint, byte, Prop*, void>) NativeLibrary.GetExport(handle, "Player_GetProps");
            Player_GetRotation = (delegate* unmanaged[Cdecl]<nint, Rotation*, void>) NativeLibrary.GetExport(handle, "Player_GetRotation");
            Player_GetSeat = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_GetSeat");
            Player_GetSocialID = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "Player_GetSocialID");
            Player_GetStreamSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Player_GetStreamSyncedMetaData");
            Player_GetStreamed = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_GetStreamed");
            Player_GetSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Player_GetSyncedMetaData");
            Player_GetVehicle = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Player_GetVehicle");
            Player_GetVisible = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_GetVisible");
            Player_GetWeaponCount = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "Player_GetWeaponCount");
            Player_GetWeaponTintIndex = (delegate* unmanaged[Cdecl]<nint, uint, byte>) NativeLibrary.GetExport(handle, "Player_GetWeaponTintIndex");
            Player_GetWeapons = (delegate* unmanaged[Cdecl]<nint, WeaponArray*, void>) NativeLibrary.GetExport(handle, "Player_GetWeapons");
            Player_GiveWeapon = (delegate* unmanaged[Cdecl]<nint, uint, int, byte, void>) NativeLibrary.GetExport(handle, "Player_GiveWeapon");
            Player_HasMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Player_HasMetaData");
            Player_HasStreamSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Player_HasStreamSyncedMetaData");
            Player_HasSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Player_HasSyncedMetaData");
            Player_HasWeaponComponent = (delegate* unmanaged[Cdecl]<nint, uint, uint, byte>) NativeLibrary.GetExport(handle, "Player_HasWeaponComponent");
            Player_IsAiming = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsAiming");
            Player_IsConnected = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsConnected");
            Player_IsCrouching = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsCrouching");
            Player_IsDead = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsDead");
            Player_IsEntityInStreamingRange_Player = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Player_IsEntityInStreamingRange_Player");
            Player_IsEntityInStreamingRange_Vehicle = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Player_IsEntityInStreamingRange_Vehicle");
            Player_IsFlashlightActive = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsFlashlightActive");
            Player_IsInRagdoll = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsInRagdoll");
            Player_IsInVehicle = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsInVehicle");
            Player_IsJumping = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsJumping");
            Player_IsReloading = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsReloading");
            Player_IsShooting = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsShooting");
            Player_IsStealthy = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsStealthy");
            Player_IsSuperJumpEnabled = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Player_IsSuperJumpEnabled");
            Player_Kick = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Player_Kick");
            Player_PlayAmbientSpeech = (delegate* unmanaged[Cdecl]<nint, nint, nint, uint, void>) NativeLibrary.GetExport(handle, "Player_PlayAmbientSpeech");
            Player_RemoveAllWeapons = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Player_RemoveAllWeapons");
            Player_RemoveFaceFeature = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Player_RemoveFaceFeature");
            Player_RemoveHeadOverlay = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Player_RemoveHeadOverlay");
            Player_RemoveRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Player_RemoveRef");
            Player_RemoveWeapon = (delegate* unmanaged[Cdecl]<nint, uint, byte>) NativeLibrary.GetExport(handle, "Player_RemoveWeapon");
            Player_RemoveWeaponComponent = (delegate* unmanaged[Cdecl]<nint, uint, uint, void>) NativeLibrary.GetExport(handle, "Player_RemoveWeaponComponent");
            Player_SetArmor = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Player_SetArmor");
            Player_SetClothes = (delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, byte, void>) NativeLibrary.GetExport(handle, "Player_SetClothes");
            Player_SetCurrentWeapon = (delegate* unmanaged[Cdecl]<nint, uint, void>) NativeLibrary.GetExport(handle, "Player_SetCurrentWeapon");
            Player_SetDateTime = (delegate* unmanaged[Cdecl]<nint, int, int, int, int, int, int, void>) NativeLibrary.GetExport(handle, "Player_SetDateTime");
            Player_SetDimension = (delegate* unmanaged[Cdecl]<nint, int, void>) NativeLibrary.GetExport(handle, "Player_SetDimension");
            Player_SetDlcClothes = (delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, byte, uint, void>) NativeLibrary.GetExport(handle, "Player_SetDlcClothes");
            Player_SetDlcProps = (delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, uint, void>) NativeLibrary.GetExport(handle, "Player_SetDlcProps");
            Player_SetEyeColor = (delegate* unmanaged[Cdecl]<nint, ushort, byte>) NativeLibrary.GetExport(handle, "Player_SetEyeColor");
            Player_SetFaceFeature = (delegate* unmanaged[Cdecl]<nint, byte, float, byte>) NativeLibrary.GetExport(handle, "Player_SetFaceFeature");
            Player_SetHairColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Player_SetHairColor");
            Player_SetHairHighlightColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Player_SetHairHighlightColor");
            Player_SetHeadBlendData = (delegate* unmanaged[Cdecl]<nint, uint, uint, uint, uint, uint, uint, float, float, float, void>) NativeLibrary.GetExport(handle, "Player_SetHeadBlendData");
            Player_SetHeadBlendPaletteColor = (delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, byte>) NativeLibrary.GetExport(handle, "Player_SetHeadBlendPaletteColor");
            Player_SetHeadOverlay = (delegate* unmanaged[Cdecl]<nint, byte, byte, float, byte>) NativeLibrary.GetExport(handle, "Player_SetHeadOverlay");
            Player_SetHeadOverlayColor = (delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, byte>) NativeLibrary.GetExport(handle, "Player_SetHeadOverlayColor");
            Player_SetHealth = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Player_SetHealth");
            Player_SetIntoVehicle = (delegate* unmanaged[Cdecl]<nint, nint, byte, void>) NativeLibrary.GetExport(handle, "Player_SetIntoVehicle");
            Player_SetInvincible = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Player_SetInvincible");
            Player_SetMaxArmor = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Player_SetMaxArmor");
            Player_SetMaxHealth = (delegate* unmanaged[Cdecl]<nint, ushort, void>) NativeLibrary.GetExport(handle, "Player_SetMaxHealth");
            Player_SetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Player_SetMetaData");
            Player_SetModel = (delegate* unmanaged[Cdecl]<nint, uint, void>) NativeLibrary.GetExport(handle, "Player_SetModel");
            Player_SetNetworkOwner = (delegate* unmanaged[Cdecl]<nint, nint, byte, void>) NativeLibrary.GetExport(handle, "Player_SetNetworkOwner");
            Player_SetPosition = (delegate* unmanaged[Cdecl]<nint, Position, void>) NativeLibrary.GetExport(handle, "Player_SetPosition");
            Player_SetProps = (delegate* unmanaged[Cdecl]<nint, byte, ushort, byte, void>) NativeLibrary.GetExport(handle, "Player_SetProps");
            Player_SetRotation = (delegate* unmanaged[Cdecl]<nint, Rotation, void>) NativeLibrary.GetExport(handle, "Player_SetRotation");
            Player_SetStreamSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Player_SetStreamSyncedMetaData");
            Player_SetStreamed = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Player_SetStreamed");
            Player_SetSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Player_SetSyncedMetaData");
            Player_SetVisible = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Player_SetVisible");
            Player_SetWeaponTintIndex = (delegate* unmanaged[Cdecl]<nint, uint, byte, void>) NativeLibrary.GetExport(handle, "Player_SetWeaponTintIndex");
            Player_SetWeather = (delegate* unmanaged[Cdecl]<nint, uint, void>) NativeLibrary.GetExport(handle, "Player_SetWeather");
            Player_Spawn = (delegate* unmanaged[Cdecl]<nint, Position, uint, void>) NativeLibrary.GetExport(handle, "Player_Spawn");
            Resource_GetCSharpImpl = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Resource_GetCSharpImpl");
            Resource_GetDependants = (delegate* unmanaged[Cdecl]<nint, nint[], int, void>) NativeLibrary.GetExport(handle, "Resource_GetDependants");
            Resource_GetDependantsSize = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Resource_GetDependantsSize");
            Resource_GetDependencies = (delegate* unmanaged[Cdecl]<nint, nint[], int, void>) NativeLibrary.GetExport(handle, "Resource_GetDependencies");
            Resource_GetDependenciesSize = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Resource_GetDependenciesSize");
            Resource_GetExport = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Resource_GetExport");
            Resource_GetExports = (delegate* unmanaged[Cdecl]<nint, nint[], nint[], void>) NativeLibrary.GetExport(handle, "Resource_GetExports");
            Resource_GetExportsCount = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "Resource_GetExportsCount");
            Resource_GetImpl = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Resource_GetImpl");
            Resource_GetMain = (delegate* unmanaged[Cdecl]<nint, nint*, void>) NativeLibrary.GetExport(handle, "Resource_GetMain");
            Resource_GetName = (delegate* unmanaged[Cdecl]<nint, nint*, void>) NativeLibrary.GetExport(handle, "Resource_GetName");
            Resource_GetPath = (delegate* unmanaged[Cdecl]<nint, nint*, void>) NativeLibrary.GetExport(handle, "Resource_GetPath");
            Resource_GetType = (delegate* unmanaged[Cdecl]<nint, nint*, void>) NativeLibrary.GetExport(handle, "Resource_GetType");
            Resource_IsStarted = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Resource_IsStarted");
            Resource_SetExport = (delegate* unmanaged[Cdecl]<nint, nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Resource_SetExport");
            Resource_SetExports = (delegate* unmanaged[Cdecl]<nint, nint, nint[], nint[], int, void>) NativeLibrary.GetExport(handle, "Resource_SetExports");
            Resource_Start = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Resource_Start");
            Resource_Stop = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Resource_Stop");
            Server_CreateBlip = (delegate* unmanaged[Cdecl]<nint, nint, byte, Position, nint>) NativeLibrary.GetExport(handle, "Server_CreateBlip");
            Server_CreateBlipAttachedPlayer = (delegate* unmanaged[Cdecl]<nint, nint, byte, nint, nint>) NativeLibrary.GetExport(handle, "Server_CreateBlipAttachedPlayer");
            Server_CreateBlipAttachedVehicle = (delegate* unmanaged[Cdecl]<nint, nint, byte, nint, nint>) NativeLibrary.GetExport(handle, "Server_CreateBlipAttachedVehicle");
            Server_CreateCheckpoint = (delegate* unmanaged[Cdecl]<nint, byte, Position, float, float, Rgba, nint>) NativeLibrary.GetExport(handle, "Server_CreateCheckpoint");
            Server_CreateColShapeCircle = (delegate* unmanaged[Cdecl]<nint, Position, float, nint>) NativeLibrary.GetExport(handle, "Server_CreateColShapeCircle");
            Server_CreateColShapeCube = (delegate* unmanaged[Cdecl]<nint, Position, Position, nint>) NativeLibrary.GetExport(handle, "Server_CreateColShapeCube");
            Server_CreateColShapeCylinder = (delegate* unmanaged[Cdecl]<nint, Position, float, float, nint>) NativeLibrary.GetExport(handle, "Server_CreateColShapeCylinder");
            Server_CreateColShapePolygon = (delegate* unmanaged[Cdecl]<nint, float, float, Vector2[], int, nint>) NativeLibrary.GetExport(handle, "Server_CreateColShapePolygon");
            Server_CreateColShapeRectangle = (delegate* unmanaged[Cdecl]<nint, float, float, float, float, float, nint>) NativeLibrary.GetExport(handle, "Server_CreateColShapeRectangle");
            Server_CreateColShapeSphere = (delegate* unmanaged[Cdecl]<nint, Position, float, nint>) NativeLibrary.GetExport(handle, "Server_CreateColShapeSphere");
            Server_CreateVehicle = (delegate* unmanaged[Cdecl]<nint, uint, Position, Rotation, ushort*, nint>) NativeLibrary.GetExport(handle, "Server_CreateVehicle");
            Server_CreateVoiceChannel = (delegate* unmanaged[Cdecl]<nint, byte, float, nint>) NativeLibrary.GetExport(handle, "Server_CreateVoiceChannel");
            Server_DeleteMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_DeleteMetaData");
            Server_DeleteSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_DeleteSyncedMetaData");
            Server_DestroyBlip = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_DestroyBlip");
            Server_DestroyCheckpoint = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_DestroyCheckpoint");
            Server_DestroyColShape = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_DestroyColShape");
            Server_DestroyVehicle = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_DestroyVehicle");
            Server_DestroyVoiceChannel = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_DestroyVoiceChannel");
            Server_FileExists = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Server_FileExists");
            Server_FileRead = (delegate* unmanaged[Cdecl]<nint, nint, nint*, void>) NativeLibrary.GetExport(handle, "Server_FileRead");
            Server_GetEntityById = (delegate* unmanaged[Cdecl]<nint, ushort, byte*, nint>) NativeLibrary.GetExport(handle, "Server_GetEntityById");
            Server_GetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Server_GetMetaData");
            Server_GetNetTime = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Server_GetNetTime");
            Server_GetPlayerCount = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "Server_GetPlayerCount");
            Server_GetPlayers = (delegate* unmanaged[Cdecl]<nint, nint[], ulong, void>) NativeLibrary.GetExport(handle, "Server_GetPlayers");
            Server_GetResource = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Server_GetResource");
            Server_GetRootDirectory = (delegate* unmanaged[Cdecl]<nint, nint*, void>) NativeLibrary.GetExport(handle, "Server_GetRootDirectory");
            Server_GetSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Server_GetSyncedMetaData");
            Server_GetVehicleCount = (delegate* unmanaged[Cdecl]<nint, ulong>) NativeLibrary.GetExport(handle, "Server_GetVehicleCount");
            Server_GetVehicles = (delegate* unmanaged[Cdecl]<nint, nint[], ulong, void>) NativeLibrary.GetExport(handle, "Server_GetVehicles");
            Server_HasMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Server_HasMetaData");
            Server_HasSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Server_HasSyncedMetaData");
            Server_LogColored = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_LogColored");
            Server_LogDebug = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_LogDebug");
            Server_LogError = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_LogError");
            Server_LogInfo = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_LogInfo");
            Server_LogWarning = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_LogWarning");
            Server_RestartResource = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_RestartResource");
            Server_SetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Server_SetMetaData");
            Server_SetSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Server_SetSyncedMetaData");
            Server_StartResource = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_StartResource");
            Server_StopResource = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Server_StopResource");
            Server_SubscribeCommand = (delegate* unmanaged[Cdecl]<nint, nint, AltV.Net.Server.CommandCallback, byte>) NativeLibrary.GetExport(handle, "Server_SubscribeCommand");
            Server_TriggerClientEvent = (delegate* unmanaged[Cdecl]<nint, nint, nint, nint[], int, void>) NativeLibrary.GetExport(handle, "Server_TriggerClientEvent");
            Server_TriggerClientEventForAll = (delegate* unmanaged[Cdecl]<nint, nint, nint[], int, void>) NativeLibrary.GetExport(handle, "Server_TriggerClientEventForAll");
            Server_TriggerClientEventForSome = (delegate* unmanaged[Cdecl]<nint, nint[], int, nint, nint[], int, void>) NativeLibrary.GetExport(handle, "Server_TriggerClientEventForSome");
            Server_TriggerServerEvent = (delegate* unmanaged[Cdecl]<nint, nint, nint[], int, void>) NativeLibrary.GetExport(handle, "Server_TriggerServerEvent");
            Vehicle_AddRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Vehicle_AddRef");
            Vehicle_AttachToEntity_Player = (delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_AttachToEntity_Player");
            Vehicle_AttachToEntity_Vehicle = (delegate* unmanaged[Cdecl]<nint, nint, short, short, Position, Rotation, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_AttachToEntity_Vehicle");
            Vehicle_DeleteMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_DeleteMetaData");
            Vehicle_DeleteStreamSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_DeleteStreamSyncedMetaData");
            Vehicle_DeleteSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_DeleteSyncedMetaData");
            Vehicle_Detach = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Vehicle_Detach");
            Vehicle_DoesWheelHasTire = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_DoesWheelHasTire");
            Vehicle_GetAppearanceDataBase64 = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetAppearanceDataBase64");
            Vehicle_GetArmoredWindowHealth = (delegate* unmanaged[Cdecl]<nint, byte, float>) NativeLibrary.GetExport(handle, "Vehicle_GetArmoredWindowHealth");
            Vehicle_GetArmoredWindowShootCount = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetArmoredWindowShootCount");
            Vehicle_GetAttached = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetAttached");
            Vehicle_GetAttachedTo = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetAttachedTo");
            Vehicle_GetBodyAdditionalHealth = (delegate* unmanaged[Cdecl]<nint, uint>) NativeLibrary.GetExport(handle, "Vehicle_GetBodyAdditionalHealth");
            Vehicle_GetBodyHealth = (delegate* unmanaged[Cdecl]<nint, uint>) NativeLibrary.GetExport(handle, "Vehicle_GetBodyHealth");
            Vehicle_GetBumperDamageLevel = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetBumperDamageLevel");
            Vehicle_GetCustomTires = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetCustomTires");
            Vehicle_GetDamageDataBase64 = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetDamageDataBase64");
            Vehicle_GetDashboardColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetDashboardColor");
            Vehicle_GetDimension = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Vehicle_GetDimension");
            Vehicle_GetDirtLevel = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetDirtLevel");
            Vehicle_GetDoorState = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetDoorState");
            Vehicle_GetDriver = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetDriver");
            Vehicle_GetEngineHealth = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Vehicle_GetEngineHealth");
            Vehicle_GetGameStateBase64 = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetGameStateBase64");
            Vehicle_GetHeadlightColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetHeadlightColor");
            Vehicle_GetHealthDataBase64 = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetHealthDataBase64");
            Vehicle_GetID = (delegate* unmanaged[Cdecl]<nint, ushort>) NativeLibrary.GetExport(handle, "Vehicle_GetID");
            Vehicle_GetInteriorColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetInteriorColor");
            Vehicle_GetLightsMultiplier = (delegate* unmanaged[Cdecl]<nint, float>) NativeLibrary.GetExport(handle, "Vehicle_GetLightsMultiplier");
            Vehicle_GetLivery = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetLivery");
            Vehicle_GetLockState = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetLockState");
            Vehicle_GetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetMetaData");
            Vehicle_GetMod = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetMod");
            Vehicle_GetModKit = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetModKit");
            Vehicle_GetModKitsCount = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetModKitsCount");
            Vehicle_GetModel = (delegate* unmanaged[Cdecl]<nint, uint>) NativeLibrary.GetExport(handle, "Vehicle_GetModel");
            Vehicle_GetModsCount = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetModsCount");
            Vehicle_GetNeonActive = (delegate* unmanaged[Cdecl]<nint, byte*, byte*, byte*, byte*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetNeonActive");
            Vehicle_GetNeonColor = (delegate* unmanaged[Cdecl]<nint, Rgba*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetNeonColor");
            Vehicle_GetNetworkOwner = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetNetworkOwner");
            Vehicle_GetNumberplateIndex = (delegate* unmanaged[Cdecl]<nint, uint>) NativeLibrary.GetExport(handle, "Vehicle_GetNumberplateIndex");
            Vehicle_GetNumberplateText = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetNumberplateText");
            Vehicle_GetPartBulletHoles = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetPartBulletHoles");
            Vehicle_GetPartDamageLevel = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetPartDamageLevel");
            Vehicle_GetPearlColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetPearlColor");
            Vehicle_GetPetrolTankHealth = (delegate* unmanaged[Cdecl]<nint, int>) NativeLibrary.GetExport(handle, "Vehicle_GetPetrolTankHealth");
            Vehicle_GetPosition = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetPosition");
            Vehicle_GetPositionCoords2 = (delegate* unmanaged[Cdecl]<nint, float*, float*, float*, float*, float*, float*, int*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetPositionCoords2");
            Vehicle_GetPrimaryColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetPrimaryColor");
            Vehicle_GetPrimaryColorRGB = (delegate* unmanaged[Cdecl]<nint, Rgba*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetPrimaryColorRGB");
            Vehicle_GetRadioStationIndex = (delegate* unmanaged[Cdecl]<nint, uint>) NativeLibrary.GetExport(handle, "Vehicle_GetRadioStationIndex");
            Vehicle_GetRearWheelVariation = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetRearWheelVariation");
            Vehicle_GetRepairsCount = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetRepairsCount");
            Vehicle_GetRoofLivery = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetRoofLivery");
            Vehicle_GetRoofState = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetRoofState");
            Vehicle_GetRotation = (delegate* unmanaged[Cdecl]<nint, Rotation*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetRotation");
            Vehicle_GetScriptDataBase64 = (delegate* unmanaged[Cdecl]<nint, int*, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetScriptDataBase64");
            Vehicle_GetSecondaryColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetSecondaryColor");
            Vehicle_GetSecondaryColorRGB = (delegate* unmanaged[Cdecl]<nint, Rgba*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetSecondaryColorRGB");
            Vehicle_GetSpecialDarkness = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetSpecialDarkness");
            Vehicle_GetStreamSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetStreamSyncedMetaData");
            Vehicle_GetStreamed = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetStreamed");
            Vehicle_GetSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetSyncedMetaData");
            Vehicle_GetTireSmokeColor = (delegate* unmanaged[Cdecl]<nint, Rgba*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetTireSmokeColor");
            Vehicle_GetTrainCarriageConfigIndex = (delegate* unmanaged[Cdecl]<nint, sbyte>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainCarriageConfigIndex");
            Vehicle_GetTrainConfigIndex = (delegate* unmanaged[Cdecl]<nint, sbyte>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainConfigIndex");
            Vehicle_GetTrainCruiseSpeed = (delegate* unmanaged[Cdecl]<nint, float>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainCruiseSpeed");
            Vehicle_GetTrainDirection = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainDirection");
            Vehicle_GetTrainDistanceFromEngine = (delegate* unmanaged[Cdecl]<nint, float>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainDistanceFromEngine");
            Vehicle_GetTrainEngineId = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainEngineId");
            Vehicle_GetTrainForceDoorsOpen = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainForceDoorsOpen");
            Vehicle_GetTrainLinkedToBackwardId = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainLinkedToBackwardId");
            Vehicle_GetTrainLinkedToForwardId = (delegate* unmanaged[Cdecl]<nint, nint>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainLinkedToForwardId");
            Vehicle_GetTrainRenderDerailed = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainRenderDerailed");
            Vehicle_GetTrainTrackId = (delegate* unmanaged[Cdecl]<nint, sbyte>) NativeLibrary.GetExport(handle, "Vehicle_GetTrainTrackId");
            Vehicle_GetVelocity = (delegate* unmanaged[Cdecl]<nint, Position*, void>) NativeLibrary.GetExport(handle, "Vehicle_GetVelocity");
            Vehicle_GetVisible = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetVisible");
            Vehicle_GetWheelColor = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetWheelColor");
            Vehicle_GetWheelHealth = (delegate* unmanaged[Cdecl]<nint, byte, float>) NativeLibrary.GetExport(handle, "Vehicle_GetWheelHealth");
            Vehicle_GetWheelType = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetWheelType");
            Vehicle_GetWheelVariation = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetWheelVariation");
            Vehicle_GetWheelsCount = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetWheelsCount");
            Vehicle_GetWindowTint = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_GetWindowTint");
            Vehicle_HasArmoredWindows = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_HasArmoredWindows");
            Vehicle_HasMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_HasMetaData");
            Vehicle_HasStreamSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_HasStreamSyncedMetaData");
            Vehicle_HasSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_HasSyncedMetaData");
            Vehicle_HasTrainPassengerCarriages = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_HasTrainPassengerCarriages");
            Vehicle_IsDaylightOn = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsDaylightOn");
            Vehicle_IsDestroyed = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsDestroyed");
            Vehicle_IsDriftMode = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsDriftMode");
            Vehicle_IsEngineOn = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsEngineOn");
            Vehicle_IsExtraOn = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsExtraOn");
            Vehicle_IsFlamethrowerActive = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsFlamethrowerActive");
            Vehicle_IsHandbrakeActive = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsHandbrakeActive");
            Vehicle_IsLightDamaged = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsLightDamaged");
            Vehicle_IsManualEngineControl = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsManualEngineControl");
            Vehicle_IsNeonActive = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsNeonActive");
            Vehicle_IsNightlightOn = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsNightlightOn");
            Vehicle_IsPrimaryColorRGB = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsPrimaryColorRGB");
            Vehicle_IsSecondaryColorRGB = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsSecondaryColorRGB");
            Vehicle_IsSirenActive = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsSirenActive");
            Vehicle_IsSpecialLightDamaged = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsSpecialLightDamaged");
            Vehicle_IsTireSmokeColorCustom = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsTireSmokeColorCustom");
            Vehicle_IsTrainCaboose = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsTrainCaboose");
            Vehicle_IsTrainEngine = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsTrainEngine");
            Vehicle_IsTrainMissionTrain = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsTrainMissionTrain");
            Vehicle_IsWheelBurst = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsWheelBurst");
            Vehicle_IsWheelDetached = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsWheelDetached");
            Vehicle_IsWheelOnFire = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsWheelOnFire");
            Vehicle_IsWindowDamaged = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsWindowDamaged");
            Vehicle_IsWindowOpened = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_IsWindowOpened");
            Vehicle_LoadAppearanceDataFromBase64 = (delegate* unmanaged[Cdecl]<nint, string, void>) NativeLibrary.GetExport(handle, "Vehicle_LoadAppearanceDataFromBase64");
            Vehicle_LoadDamageDataFromBase64 = (delegate* unmanaged[Cdecl]<nint, string, void>) NativeLibrary.GetExport(handle, "Vehicle_LoadDamageDataFromBase64");
            Vehicle_LoadGameStateFromBase64 = (delegate* unmanaged[Cdecl]<nint, string, void>) NativeLibrary.GetExport(handle, "Vehicle_LoadGameStateFromBase64");
            Vehicle_LoadHealthDataFromBase64 = (delegate* unmanaged[Cdecl]<nint, string, void>) NativeLibrary.GetExport(handle, "Vehicle_LoadHealthDataFromBase64");
            Vehicle_LoadScriptDataFromBase64 = (delegate* unmanaged[Cdecl]<nint, string, void>) NativeLibrary.GetExport(handle, "Vehicle_LoadScriptDataFromBase64");
            Vehicle_RemoveRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Vehicle_RemoveRef");
            Vehicle_Repair = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "Vehicle_Repair");
            Vehicle_SetArmoredWindowHealth = (delegate* unmanaged[Cdecl]<nint, byte, float, void>) NativeLibrary.GetExport(handle, "Vehicle_SetArmoredWindowHealth");
            Vehicle_SetArmoredWindowShootCount = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetArmoredWindowShootCount");
            Vehicle_SetBodyAdditionalHealth = (delegate* unmanaged[Cdecl]<nint, uint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetBodyAdditionalHealth");
            Vehicle_SetBodyHealth = (delegate* unmanaged[Cdecl]<nint, uint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetBodyHealth");
            Vehicle_SetBumperDamageLevel = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetBumperDamageLevel");
            Vehicle_SetCustomTires = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetCustomTires");
            Vehicle_SetDashboardColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetDashboardColor");
            Vehicle_SetDimension = (delegate* unmanaged[Cdecl]<nint, int, void>) NativeLibrary.GetExport(handle, "Vehicle_SetDimension");
            Vehicle_SetDirtLevel = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetDirtLevel");
            Vehicle_SetDoorState = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetDoorState");
            Vehicle_SetDriftMode = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetDriftMode");
            Vehicle_SetEngineHealth = (delegate* unmanaged[Cdecl]<nint, int, void>) NativeLibrary.GetExport(handle, "Vehicle_SetEngineHealth");
            Vehicle_SetEngineOn = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetEngineOn");
            Vehicle_SetHeadlightColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetHeadlightColor");
            Vehicle_SetInteriorColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetInteriorColor");
            Vehicle_SetLightDamaged = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetLightDamaged");
            Vehicle_SetLightsMultiplier = (delegate* unmanaged[Cdecl]<nint, float, void>) NativeLibrary.GetExport(handle, "Vehicle_SetLightsMultiplier");
            Vehicle_SetLivery = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetLivery");
            Vehicle_SetLockState = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetLockState");
            Vehicle_SetManualEngineControl = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetManualEngineControl");
            Vehicle_SetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetMetaData");
            Vehicle_SetMod = (delegate* unmanaged[Cdecl]<nint, byte, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_SetMod");
            Vehicle_SetModKit = (delegate* unmanaged[Cdecl]<nint, byte, byte>) NativeLibrary.GetExport(handle, "Vehicle_SetModKit");
            Vehicle_SetNeonActive = (delegate* unmanaged[Cdecl]<nint, byte, byte, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetNeonActive");
            Vehicle_SetNeonColor = (delegate* unmanaged[Cdecl]<nint, Rgba, void>) NativeLibrary.GetExport(handle, "Vehicle_SetNeonColor");
            Vehicle_SetNetworkOwner = (delegate* unmanaged[Cdecl]<nint, nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetNetworkOwner");
            Vehicle_SetNumberplateIndex = (delegate* unmanaged[Cdecl]<nint, uint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetNumberplateIndex");
            Vehicle_SetNumberplateText = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetNumberplateText");
            Vehicle_SetPartBulletHoles = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetPartBulletHoles");
            Vehicle_SetPartDamageLevel = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetPartDamageLevel");
            Vehicle_SetPearlColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetPearlColor");
            Vehicle_SetPetrolTankHealth = (delegate* unmanaged[Cdecl]<nint, int, void>) NativeLibrary.GetExport(handle, "Vehicle_SetPetrolTankHealth");
            Vehicle_SetPosition = (delegate* unmanaged[Cdecl]<nint, Position, void>) NativeLibrary.GetExport(handle, "Vehicle_SetPosition");
            Vehicle_SetPrimaryColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetPrimaryColor");
            Vehicle_SetPrimaryColorRGB = (delegate* unmanaged[Cdecl]<nint, Rgba, void>) NativeLibrary.GetExport(handle, "Vehicle_SetPrimaryColorRGB");
            Vehicle_SetRadioStationIndex = (delegate* unmanaged[Cdecl]<nint, uint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetRadioStationIndex");
            Vehicle_SetRearWheels = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetRearWheels");
            Vehicle_SetRoofLivery = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetRoofLivery");
            Vehicle_SetRoofState = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetRoofState");
            Vehicle_SetRotation = (delegate* unmanaged[Cdecl]<nint, Rotation, void>) NativeLibrary.GetExport(handle, "Vehicle_SetRotation");
            Vehicle_SetSearchLight_Player = (delegate* unmanaged[Cdecl]<nint, byte, nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_SetSearchLight_Player");
            Vehicle_SetSearchLight_Vehicle = (delegate* unmanaged[Cdecl]<nint, byte, nint, byte>) NativeLibrary.GetExport(handle, "Vehicle_SetSearchLight_Vehicle");
            Vehicle_SetSecondaryColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetSecondaryColor");
            Vehicle_SetSecondaryColorRGB = (delegate* unmanaged[Cdecl]<nint, Rgba, void>) NativeLibrary.GetExport(handle, "Vehicle_SetSecondaryColorRGB");
            Vehicle_SetSirenActive = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetSirenActive");
            Vehicle_SetSpecialDarkness = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetSpecialDarkness");
            Vehicle_SetSpecialLightDamaged = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetSpecialLightDamaged");
            Vehicle_SetStreamSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetStreamSyncedMetaData");
            Vehicle_SetStreamed = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetStreamed");
            Vehicle_SetSyncedMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetSyncedMetaData");
            Vehicle_SetTireSmokeColor = (delegate* unmanaged[Cdecl]<nint, Rgba, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTireSmokeColor");
            Vehicle_SetTrainCarriageConfigIndex = (delegate* unmanaged[Cdecl]<nint, sbyte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainCarriageConfigIndex");
            Vehicle_SetTrainConfigIndex = (delegate* unmanaged[Cdecl]<nint, sbyte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainConfigIndex");
            Vehicle_SetTrainCruiseSpeed = (delegate* unmanaged[Cdecl]<nint, float, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainCruiseSpeed");
            Vehicle_SetTrainDirection = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainDirection");
            Vehicle_SetTrainDistanceFromEngine = (delegate* unmanaged[Cdecl]<nint, float, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainDistanceFromEngine");
            Vehicle_SetTrainEngineId = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainEngineId");
            Vehicle_SetTrainForceDoorsOpen = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainForceDoorsOpen");
            Vehicle_SetTrainHasPassengerCarriages = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainHasPassengerCarriages");
            Vehicle_SetTrainIsCaboose = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainIsCaboose");
            Vehicle_SetTrainIsEngine = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainIsEngine");
            Vehicle_SetTrainLinkedToBackwardId = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainLinkedToBackwardId");
            Vehicle_SetTrainLinkedToForwardId = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainLinkedToForwardId");
            Vehicle_SetTrainMissionTrain = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainMissionTrain");
            Vehicle_SetTrainRenderDerailed = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainRenderDerailed");
            Vehicle_SetTrainTrackId = (delegate* unmanaged[Cdecl]<nint, sbyte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetTrainTrackId");
            Vehicle_SetVisible = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetVisible");
            Vehicle_SetWheelBurst = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWheelBurst");
            Vehicle_SetWheelColor = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWheelColor");
            Vehicle_SetWheelDetached = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWheelDetached");
            Vehicle_SetWheelFixed = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWheelFixed");
            Vehicle_SetWheelHasTire = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWheelHasTire");
            Vehicle_SetWheelHealth = (delegate* unmanaged[Cdecl]<nint, byte, float, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWheelHealth");
            Vehicle_SetWheelOnFire = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWheelOnFire");
            Vehicle_SetWheels = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWheels");
            Vehicle_SetWindowDamaged = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWindowDamaged");
            Vehicle_SetWindowOpened = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWindowOpened");
            Vehicle_SetWindowTint = (delegate* unmanaged[Cdecl]<nint, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_SetWindowTint");
            Vehicle_ToggleExtra = (delegate* unmanaged[Cdecl]<nint, byte, byte, void>) NativeLibrary.GetExport(handle, "Vehicle_ToggleExtra");
            VoiceChannel_AddPlayer = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "VoiceChannel_AddPlayer");
            VoiceChannel_AddRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "VoiceChannel_AddRef");
            VoiceChannel_DeleteMetaData = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "VoiceChannel_DeleteMetaData");
            VoiceChannel_GetMaxDistance = (delegate* unmanaged[Cdecl]<nint, float>) NativeLibrary.GetExport(handle, "VoiceChannel_GetMaxDistance");
            VoiceChannel_GetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint>) NativeLibrary.GetExport(handle, "VoiceChannel_GetMetaData");
            VoiceChannel_HasMetaData = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "VoiceChannel_HasMetaData");
            VoiceChannel_HasPlayer = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "VoiceChannel_HasPlayer");
            VoiceChannel_IsPlayerMuted = (delegate* unmanaged[Cdecl]<nint, nint, byte>) NativeLibrary.GetExport(handle, "VoiceChannel_IsPlayerMuted");
            VoiceChannel_IsSpatial = (delegate* unmanaged[Cdecl]<nint, byte>) NativeLibrary.GetExport(handle, "VoiceChannel_IsSpatial");
            VoiceChannel_MutePlayer = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "VoiceChannel_MutePlayer");
            VoiceChannel_RemovePlayer = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "VoiceChannel_RemovePlayer");
            VoiceChannel_RemoveRef = (delegate* unmanaged[Cdecl]<nint, void>) NativeLibrary.GetExport(handle, "VoiceChannel_RemoveRef");
            VoiceChannel_SetMetaData = (delegate* unmanaged[Cdecl]<nint, nint, nint, void>) NativeLibrary.GetExport(handle, "VoiceChannel_SetMetaData");
            VoiceChannel_UnmutePlayer = (delegate* unmanaged[Cdecl]<nint, nint, void>) NativeLibrary.GetExport(handle, "VoiceChannel_UnmutePlayer");

        }
    }
}