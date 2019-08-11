﻿namespace RealismOverhaul.Communications
{
    class AntennaSpecs
    {
        public float TxUsedPower { get; set; }
        public float IdlePower { get; set; }
        public double CommNetPower { get; set; }
        public float MinDataRate { get; set; }
        public float MaxDataRate { get; set; }
        public bool Valid { get; set; }

        public AntennaSpecs(float txUsedPower, float idlePower, double commNetPower, float minDataRate, float maxDataRate, bool valid = true)
        {
            TxUsedPower = txUsedPower;
            IdlePower = idlePower;
            CommNetPower = commNetPower;
            MinDataRate = minDataRate;
            MaxDataRate = maxDataRate;
            Valid = valid;
        }
    }
}
