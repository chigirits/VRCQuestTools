﻿// <copyright file="I18nJapanese.cs" company="kurotu">
// Copyright (c) kurotu.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
// </copyright>

#pragma warning disable SA1201 // Elements should appear in the correct order
#pragma warning disable SA1516 // Elements should be separated by blank line
#pragma warning disable SA1600 // Elements should be documented

namespace KRT.VRCQuestTools.I18n
{
    /// <summary>
    /// Japanese strings.
    /// </summary>
    internal class I18nJapanese : I18nBase
    {
        internal override string CancelLabel => "キャンセル";
        internal override string CloseLabel => "閉じる";

        // Convert Avatar for Quest
        internal override string OverwriteWarningDialogButtonCancel => "キャンセル";
        internal override string OverwriteWarningDialogButtonOK => "OK";
        internal override string OverwriteWarningDialogButtonUseAltDir(string altDir) => $"\"{altDir}\" を使用する";
        internal override string OverwriteWarningDialogMessage(string artifactsDir) => $"\"{artifactsDir}\" が既に存在します。上書きしますか？";
        internal override string OverwriteWarningDialogTitle => $"{VRCQuestTools.Name} 警告";
        internal override string AvatarLabel => "アバター";
        internal override string GenerateQuestTexturesLabel => "Quest用のテクスチャを生成する";
        internal override string QuestTexturesDescription => "メインテクスチャ以外にもマテリアルのパラメーターを参照してテクスチャを生成し、PC版アバターの外観に近づけます。";
        internal override string SupportedShadersLabel => "対応シェーダー";
        internal override string SaveToLabel => "保存先フォルダ";
        internal override string SelectButtonLabel => "選択";
        internal override string ConvertButtonLabel => "変換";
        internal override string UpdateTexturesLabel => "Quest用テクスチャのみ更新";
        internal override string ConvertingMaterialsDialogMessage => "マテリアルを変換中";
        internal override string GeneratingTexturesDialogMessage => "テクスチャを生成中";
        internal override string MaterialExceptionDialogMessage => "マテリアルの変換中にエラーが発生しました。変換を中止します。";
        internal override string AnimationClipExceptionDialogMessage => "アニメーションの変換中にエラーが発生しました。変換を中止します。";
        internal override string AnimatorControllerExceptionDialogMessage => "Animator Controllerの変換中にエラーが発生しました。変換を中止します。";
        internal override string WarningForPerformance => "ほとんどの場合、変換後のアバターは Quest のパフォーマンスランクで Very Poor になります。デフォルトではフォールバックアバターが表示され、見る側が Avatar Display 設定で個別に表示する必要があります。";
        internal override string WarningForAppearance => "テクスチャの透過が反映されないため、頬染めなどの表現に問題がある場合があります。そのような場合はアニメーション編集やメッシュ削除などの方法で対策する必要があります。\n\n" +
            "別のBlueprint IDでのアップロードやAvatars 3.0のローカルテストを使用して、変換後のアバターの見た目をPCで確認することをお勧めします。";
        internal override string WarningForUnsupportedShaders => $"以下のマテリアルは非対応のシェーダーを使用しており、テクスチャが正しく生成されない可能性があります。\n「{GenerateQuestTexturesLabel}」をオフにするとシェーダーのみを変更します。";
        internal override string AlertForComponents => "以下の非対応コンポーネントを削除します。変換後、アバターの機能に支障がないか確認してください。";
        internal override string AlertForMaterialAnimation => "マテリアルを変更するアニメーションがあるため、Animator ControllerおよびアニメーションをQuest用に複製・変換します。";
        internal override string TexturesSizeLimitLabel => "最大テクスチャサイズ";
        internal override string CompletedDialogMessage(string originalName) => $"{originalName} の変換が完了しました。\n表情などを確認した後、PC用と同じBlueprint IDを使ってAndroidプラットフォーム用にアップロードしてください。";

        // Remove Missing Components
        internal override string NoMissingComponentsMessage(string objectName) => $"{objectName} に \"Missing\" 状態のコンポーネントはありません。";
        internal override string MissingRemoverConfirmationMessage(string objectName) => $"{objectName} から \"Missing\" 状態のコンポーネントを削除します。";
        internal override string UnpackPrefabMessage => "同時に Unpack Prefab を実行します。";

        // BlendShapes Copy
        internal override string SourceMeshLabel => "コピー元メッシュ";
        internal override string TargetMeshLabel => "コピー先メッシュ";
        internal override string CopyButtonLabel => "ブレンドシェイプの値をコピー";
        internal override string SwitchButtonLabel => "コピー元/コピー先を入れ替え";

        // Remove Unsupported Components
        internal override string NoUnsupportedComponentsMessage(string objectName) => $"{objectName} に非対応コンポーネントはありません。";
        internal override string UnsupportedRemoverConfirmationMessage(string objectName) => $"{objectName} から以下の非対応コンポーネントを削除します。";

        // Metallic Smoothness
        internal override string TextureLabel => "テクスチャ";
        internal override string InvertLabel => "反転";
        internal override string SaveFileDialogTitle(string thing) => $"{thing} を保存";
        internal override string SaveFileDialogMessage => "テクスチャの保存先を選択してください";
        internal override string GenerateButtonLabel => "Metallic Smoothness を生成";

        // Unity Settings
        internal override string CacheServerModeLabel => "キャッシュサーバー";
        internal override string CacheServerHelp => "ローカルキャッシュサーバーを使用すると、テクスチャ圧縮などの結果を保存して次回にかかる時間を短縮できます。デフォルト設定では C ドライブを最大 10 GB 使用します。";
        internal override string CacheServerButtonLabel => "ローカルキャッシュサーバーを有効化";
        internal override string TextureCompressionLabel => "Android テクスチャ圧縮";
        internal override string TextureCompressionHelp => "ASTCを使用するとQuest用のテクスチャ圧縮に時間がかかる代わりに画質が向上します。";
        internal override string TextureCompressionButtonLabel => "ASTCでテクスチャを圧縮";
        internal override string ApplyAllButtonLabel => "すべての設定を適用";
        internal override string ShowOnStartupLabel => "起動時に表示";
        internal override string AllAppliedHelp => "すべての推奨設定が適用されています。";

        // Check for Update
        internal override string CheckLater => "後で確認";
        internal override string GetUpdate => "アップデート";
        internal override string NewVersionIsAvailable(string latestVersion) => $"新しいバージョン {latestVersion} があります。";
        internal override string ThereIsNoUpdate => "アップデートはありません。";
    }
}
