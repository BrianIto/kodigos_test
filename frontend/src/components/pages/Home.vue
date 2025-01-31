<script setup lang="ts">
import { ref, defineProps } from "vue";
import {
  BeakerIcon,
  HomeIcon,
  DocumentPlusIcon,
  DocumentTextIcon,
  ClipboardDocumentCheckIcon,
  ClipboardDocumentListIcon,
  DocumentDuplicateIcon,
} from "@heroicons/vue/24/outline";
import Sidemenu from "../molecules/Sidemenu.vue";
import Header from "../organisms/Header.vue";
import ValueAnalysisFilter from "../organisms/ValueAnalysis/Filters.vue";
import InputText from "../atoms/InputText.vue";
import FileUpload from "../molecules/FileUpload.vue";
import Button from "../atoms/Button.vue";
import ConfirmDialog from "../organisms/ConfirmDialog.vue";
import ReproveDialog from "../organisms/ReproveDialog.vue";
import Toast from "../molecules/Toast.vue";
import type { Product } from "../../services/ProductService";
import type { ValueAnalysis } from "../../services/ValueAnalysis";

const confirmDialog = ref(null);
const repproveDialog = ref(null);

const { products, ValueAnalysis } = defineProps<{
  products: Product[];
  valueAnalysis: ValueAnalysis[];
}>();
const count = ref(0);

const menuButtons = ref([
  {
    icon: HomeIcon,
    key: "a",
    active: true,
    disabled: false,
    onClick: () => {},
  },

  {
    icon: DocumentPlusIcon,
    key: "a",
    onClick: () => {},
  },
  {
    icon: DocumentTextIcon,
    key: "a",
    onClick: () => {},
  },
  {
    icon: ClipboardDocumentCheckIcon,
    key: "a",
    onClick: () => {},
  },
  {
    icon: ClipboardDocumentListIcon,
    key: "a",
    onClick: () => {},
  },
  {
    icon: DocumentDuplicateIcon,
    key: "a",
    onClick: () => {},
  },
]);

function handleSubmit() {
  confirmDialog.value.open();
  console.log(products);
}

function handleApprove() {
  createSuccessToast();
  confirmDialog.value.close();
}

function handleReprove() {
  confirmDialog.value.close();
  repproveDialog.value.open();
}

function handleConfirmReprove(data) {
  console.log(data);
  repproveDialog.value.close();
}

const toastVisible = ref(false);
const toastMessage = ref("");
const toastType = ref("success");

function createSuccessToast() {
  toastType.value = "success";
  toastMessage.value = "Pedido criado para o Protheus.";
  toastVisible.value = true;
}
</script>

<template>
  <Header />
  <div class="flex relative min-h-screen -mt-16">
    <Sidemenu :items="menuButtons" />
    <div class="flex-1">
      <section
        class="flex flex-col items-start bg-zinc-50 md:pl-12 md:px-12 px-3 pt-22 h-full"
      >
        <ValueAnalysisFilter />
        <article class="bg-white rounded-xl my-8 py-5 px-8 w-full">
          <h2 class="text-xl font-semibold text-zinc-700 my-1">
            Editar Valores
          </h2>
          <p class="text-sm text-zinc-400">
            Informe os valores repassados pelos fornecedores.
          </p>
          <div class="max-w-sm lg:max-w-full overflow-auto">
            <table class="text-center w-full relative my-5">
              <thead class="bg-zinc-100 text-zinc-600 text-sm font-normal">
                <tr>
                  <th class="py-3 rounded-tl-lg font-medium">Código</th>
                  <th class="font-medium">Produto</th>
                  <th class="font-medium">Descrição</th>
                  <th class="font-medium">Quantidade</th>
                  <th
                    class="font-medium last:rounded-tr-lg"
                    v-for="supplier in valueAnalysis.suppliers"
                  >
                    Fornecedor {{ supplier.id }}
                  </th>
                </tr>
              </thead>
              <tbody>
                <tr
                  class="text-sm text-zinc-600 group font-light"
                  v-for="product in valueAnalysis.products"
                >
                  <td
                    class="py-3 border border-zinc-100 min-w-20 group-hover:bg-orange-50 bg-opacity-50 duration-200"
                  >
                    {{ product.id }}
                  </td>
                  <td
                    class="border border-zinc-100 min-w-44 group-hover:bg-orange-50 duration-200"
                  >
                    {{ product.name }}
                  </td>
                  <td
                    class="border border-zinc-100 min-w-40 group-hover:bg-orange-50 duration-200"
                  >
                    {{ product.description }}
                  </td>

                  <td
                    class="border border-zinc-100 group-hover:bg-orange-50 duration-200"
                  >
                    {{ product.amount }}
                  </td>
                  <td
                    class="border border-zinc-100 min-w-44 group-hover:bg-orange-50 duration-200"
		    v-for="supplier in valueAnalysis.suppliers"
                  >
                    <div class="flex justify-center items-center">
                      <span class="text-zinc-400 mr-2">R$ </span> &nbsp;
                      <div class="max-w-24 inline-block"><InputText /></div>
                    </div>
                  </td>
                </tr>
              </tbody>
            </table>
          </div>
          <h2 class="text-xl font-semibold text-zinc-700 my-1">Anexos</h2>
          <p class="text-sm text-zinc-400">Adicione as cotações enviadas.</p>
          <FileUpload />
          <h2 class="text-xl font-semibold text-zinc-700 my-1 mt-8">
            Fornecedores Selecionados
          </h2>
          <p class="text-sm text-zinc-400">
            Vencedores Escolhidos por item e análise da última compra.
          </p>

          <div class="max-w-sm lg:max-w-full overflow-auto">
            <table class="w-full text-center my-5 overflow-scroll">
              <thead class="bg-zinc-100 text-zinc-600 text-sm font-normal">
                <tr>
                  <th class="py-3 rounded-tl-lg font-medium">Código</th>
                  <th class="font-medium">Produto</th>
                  <th class="font-medium">Descrição</th>
                  <th class="font-medium">Quantidade</th>
                  <th
                    class="font-medium last:rounded-tr-lg"
                    v-for="supplier in valueAnalysis.suppliers"
                  >
                    Fornecedor {{ supplier.id }}
                  </th>
                </tr>
              </thead>
              <tbody>
                <tr
                  class="text-sm text-zinc-600 group font-light"
                  v-for="product in valueAnalysis.products"
                >
                  <td
                    class="py-3 border border-zinc-100 min-w-20 group-hover:bg-orange-50 bg-opacity-50 duration-200"
                  >
                    {{ product.id }}
                  </td>

                  <td
                    class="border border-zinc-100 min-w-44 group-hover:bg-orange-50 duration-200"
                  >
                    {{ product.name }}
                  </td>
                  <td
                    class="border border-zinc-100 min-w-40 group-hover:bg-orange-50 duration-200"
                  >
                    {{ product.description }}
                  </td>
                  <td
                    class="border border-zinc-100 group-hover:bg-orange-50 duration-200"
                  >
                    100
                  </td>
                  <td
                    v-for="product in valueAnalysis.products"
                    class="border border-zinc-100 group-hover:bg-orange-50 duration-200"
                  >
                    <div class="flex justify-center items-center">
                      <span class="text-zinc-400 mr-2">R$ </span> &nbsp;
                      <div class="max-w-24 inline-block"><InputText /></div>
                    </div>
                  </td>
                </tr>
              </tbody>
            </table>
          </div>
          <div class="flex gap-5 justify-end mt-12">
            <Button type="nobg">Cancelar</Button>
            <Button type="secondary">Salvar Rascunho</Button>
            <Button type="primary" @click="handleSubmit">Finalizar</Button>
          </div>
        </article>
      </section>
      <ConfirmDialog
        ref="confirmDialog"
        title="Enviar Cotação"
        @approve="handleApprove"
        @repprove="handleReprove"
        description="Deseja enviar agora o pedido para o Protheus?"
      />
      <ReproveDialog @confirm="handleConfirmReprove" ref="repproveDialog" />
    </div>
  </div>
  <Transition>
    <Toast
      v-if="toastVisible"
      :message="toastMessage"
      :type="toastType"
      @close="toastVisible = false"
    />
  </Transition>
</template>

<style scoped>
/* we will explain what these classes do next! */
.v-enter-active,
.v-leave-active {
  transition: opacity 0.5s ease;
}

.v-enter-from,
.v-leave-to {
  opacity: 0;
}
</style>
