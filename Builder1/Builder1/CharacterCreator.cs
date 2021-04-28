namespace Builder
{
    class CharacterCreator
    {
        public Player Create(PlayerBuilder playerBuilder)
        {
            playerBuilder.EquipRightHand();
            playerBuilder.EquipLeftHand();
            playerBuilder.EquipHead();
            playerBuilder.EquipChest();
            playerBuilder.EquipLegs();
            return playerBuilder.Build();
        }
    }
}
