using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freesense
{
    class gereksizler
    {
        /*
                // oyuncuların toplam ne kadar hit yaptığını gösterir
                Int64 m_pBulletServices = memory.Read<Int64>(csPlayerPawn + 0x16B0);
                Int64 m_totalHitsOnServer  = memory.Read<Int64>((ulong)(m_pBulletServices + 0x40));
                Console.WriteLine("value -> " + value);


                // local pozisyona çok yakın bir değer veriyor saçma
                Vector3 m_vecLastClipCameraForward = memory.Read<Vector3>(localplayer + 0x128C);
                Console.WriteLine("m_vecLastClipCameraForward: " + m_vecLastClipCameraForward);


                // bu bi değer veriyor ama anlamadım aq
                float m_flHitHeading = memory.Read<float>(csPlayerPawn + 0x1424);
                //Console.WriteLine("m_flHitHeading: " + m_flHitHeading);


                // dumperde veri yok aq
                //Console.WriteLine("name: " + name);
                if (name.Contains("grenade_projectile"))
                {
                    Console.WriteLine("name: " + name);
                }


                // chams denemesi yarrakla sonuçlandı oldheald da 0 dönüyor hep
                if (name.Contains("basemodelentity"))
                {
                    Vector3 m_clrRender = memory.Read<Vector3>((ulong)(entController + 0xA73));
                    //Console.WriteLine("m_clrRender : " + m_clrRender);

                    int oldhealth = memory.Read<int>((ulong)(entController + 0xA6C));
                    Console.WriteLine("oldhealth : " + oldhealth);
                }


            // buna bakılacak ama olmaz gibi. QAngle.X 0 ve 2 arası değer veriyor.
            public static class C_CSGOViewModel // C_PredictedViewModel
            {
                public const int m_bShouldIgnoreOffsetAndAccuracy = 0xF10; // bool
                public const int m_nWeaponParity = 0xF14; // uint32_t
                public const int m_nOldWeaponParity = 0xF18; // uint32_t
                public const int m_nLastKnownAssociatedWeaponEntIndex = 0xF1C; // CEntityIndex
                public const int m_bNeedToQueueHighResComposite = 0xF20; // bool
                public const int m_vLoweredWeaponOffset = 0xF64; // QAngle
            }
                if (name.Contains("csgo_viewmodel"))
                {
                    //Console.WriteLine("name: " + name);

                    bool m_bShouldIgnoreOffsetAndAccuracy = memory.Read<bool>((ulong)(entController + C_CSGOViewModel.m_bShouldIgnoreOffsetAndAccuracy));
                    uint m_nWeaponParity = memory.Read<uint>((ulong)(entController + C_CSGOViewModel.m_nWeaponParity));
                    uint m_nOldWeaponParity = memory.Read<uint>((ulong)(entController + C_CSGOViewModel.m_nOldWeaponParity));
                    int m_nLastKnownAssociatedWeaponEntIndex = memory.Read<int>((ulong)(entController + C_CSGOViewModel.m_nLastKnownAssociatedWeaponEntIndex));
                    bool m_bNeedToQueueHighResComposite = memory.Read<bool>((ulong)(entController + C_CSGOViewModel.m_bNeedToQueueHighResComposite));
                    Vector3 m_vLoweredWeaponOffset = memory.Read<Vector3>((ulong)(entController + C_CSGOViewModel.m_vLoweredWeaponOffset));

                    Console.WriteLine("m_bShouldIgnoreOffsetAndAccuracy: " + m_bShouldIgnoreOffsetAndAccuracy);
                    Console.WriteLine("m_nWeaponParity: " + m_nWeaponParity);
                    Console.WriteLine("m_nOldWeaponParity: " + m_nOldWeaponParity);
                    Console.WriteLine("m_nLastKnownAssociatedWeaponEntIndex: " + m_nLastKnownAssociatedWeaponEntIndex);
                    Console.WriteLine("m_bNeedToQueueHighResComposite: " + m_bNeedToQueueHighResComposite);
                    Console.WriteLine("m_vLoweredWeaponOffset: " + m_vLoweredWeaponOffset);
                }









        */
    }
}
