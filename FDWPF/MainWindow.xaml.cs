using FDManager;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FDWPF
{
	public partial class MainWindow : Window
	{
		private CharacterManager _characterManager = new CharacterManager();
		private MoveManager _moveManager = new MoveManager();

		public MainWindow()
		{
			InitializeComponent();
			PopulateSelectCharacterComboBox();
		}

		private void PopulateSelectCharacterComboBox()
		{
			SelectCharacterComboBox.ItemsSource = _characterManager.RetrieveAllCharacters();
		}

		private void SelectCharacterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			DepopulateMoveDataBoxes();

			_characterManager.SetSelectedCharacter(SelectCharacterComboBox.SelectedItem);
			SelectMoveComboBox.ItemsSource = _moveManager.RetrieveACharactersMoveList(_characterManager.SelectedCharacter.CharacterId);

			var resourceUri = new Uri(_characterManager.SelectedCharacter.CharacterPicture);
			FrameDataPicture.Source = new BitmapImage(resourceUri);

			QuoteTextBlock.Text = _characterManager.SelectedCharacter.Quote;
			HealthTextBox.Text = _characterManager.SelectedCharacter.Health.ToString();
			StunTextBox.Text = _characterManager.SelectedCharacter.Stun.ToString();
			ForwardDashTextBox.Text = _characterManager.SelectedCharacter.ForwardDash.ToString();
			BackDashTextBox.Text = _characterManager.SelectedCharacter.BackDash.ToString();
		}

		private void SelectMoveComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (SelectMoveComboBox.SelectedItem != null)
			{
				_moveManager.SetSelectedMove(SelectMoveComboBox.SelectedItem);

				var resourceUri = new Uri(_moveManager.SelectedMove.MovePicture);
				FrameDataPicture.Source = new BitmapImage(resourceUri);

				StartUpTextBox.Text = _moveManager.SelectedMove.StartUp.ToString();
				ActiveTextBox.Text = _moveManager.SelectedMove.Active.ToString();
				RecoveryTextBox.Text = _moveManager.SelectedMove.Recovery.ToString();
				OnBlockTextBox.Text = _moveManager.SelectedMove.OnBlock.ToString();
				OnHitTextBox.Text = _moveManager.SelectedMove.OnHit.ToString();
				DamageTextBox.Text = _moveManager.SelectedMove.Damage.ToString();
				StunDamageTextBox.Text = _moveManager.SelectedMove.Stun.ToString();
			}
		}

		private void DepopulateMoveDataBoxes()
		{
			StartUpTextBox.Text =
				ActiveTextBox.Text =
				RecoveryTextBox.Text =
				OnBlockTextBox.Text =
				OnHitTextBox.Text =
				DamageTextBox.Text =
				StunDamageTextBox.Text = null;
		}
	}
}